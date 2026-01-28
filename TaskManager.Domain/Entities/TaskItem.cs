using TaskStatus = TaskManager.Domain.Enums.TaskStatus;
using TaskPriority = TaskManager.Domain.Enums.TaskPriority;

namespace TaskManager.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public TaskStatus Status { get; set; } = TaskStatus.Pendiente;
        public TaskPriority Priority { get; set; } = TaskPriority.Media;
        public DateTime DueDate { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; } = true;
    }
}