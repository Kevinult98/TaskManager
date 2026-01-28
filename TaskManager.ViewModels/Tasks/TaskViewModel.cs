using TaskManager.Data.Interfaces;
using TaskManager.ViewModels.Base;
using TaskItem = TaskManager.Domain.Entities.TaskItem;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;

namespace TaskManager.ViewModels.Tasks
{
    public class TaskViewModel : ViewModelBase
    {
        private readonly ITaskRepository _taskRepository;

        private List<TaskItem> _tasks = new();
        private TaskItem? _selectedTask;

        public TaskViewModel(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            LoadTasks();
        }

        public List<TaskItem> Tasks
        {
            get => _tasks;
            private set
            {
                _tasks = value;
                OnPropertyChanged();
            }
        }

        public TaskItem? SelectedTask
        {
            get => _selectedTask;
            set
            {
                _selectedTask = value;
                OnPropertyChanged();
            }
        }

        public void LoadTasks()
        {
            Tasks = _taskRepository.GetAll().ToList();
        }

        public void AddTask(TaskItem task)
        {
            if (task.Status != TaskStatus.Pendiente)
                throw new InvalidOperationException(
                    "Una tarea nueva debe iniciar en estado Pendiente.");

            _taskRepository.Add(task);
            LoadTasks();
        }

        public void UpdateTask(TaskItem task)
        {
            if (task.Status != TaskStatus.Pendiente)
                throw new InvalidOperationException(
                    "Solo se pueden editar tareas en estado Pendiente.");

            _taskRepository.Update(task);
            LoadTasks();
        }

        public void DeleteTask(TaskItem task)
        {
            if (task.Status == TaskStatus.EnProceso)
                throw new InvalidOperationException(
                    "No se pueden eliminar tareas en proceso.");

            _taskRepository.Delete(task.Id);
            LoadTasks();
        }

        public void ChangeStatus(TaskItem task)
        {
            task.Status = task.Status switch
            {
                TaskStatus.Pendiente => TaskStatus.EnProceso,
                TaskStatus.EnProceso => TaskStatus.Terminada,
                _ => throw new InvalidOperationException(
                        "La tarea ya está terminada.")
            };

            _taskRepository.Update(task);
            LoadTasks();
        }

        public void ApplyAdvancedFilter(
            TaskStatus? status,
            DateTime? from,
            DateTime? to)
        {
            var tasks = _taskRepository.GetAll();

            if (status.HasValue)
                tasks = tasks.Where(t => t.Status == status.Value);

            if (from.HasValue)
                tasks = tasks.Where(t => t.DueDate.Date >= from.Value.Date);

            if (to.HasValue)
                tasks = tasks.Where(t => t.DueDate.Date <= to.Value.Date);

            Tasks = tasks.ToList();
        }
    }
}
