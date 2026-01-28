using TaskManager.Domain.Entities;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;
using TaskPriority = TaskManager.Domain.Enums.TaskPriority;
using TaskManager.UI.Helpers;

namespace TaskManager.UI
{
    public partial class TaskForm : Form
    {
        public TaskItem Task { get; private set; }
        public TaskForm(TaskItem? task = null)
        {
            InitializeComponent();
            ConfigureControls();
            InitializeTask(task);
        }

        private void ConfigureControls()
        {
            dtpDueDate.MinDate = DateTime.Today;
            cmbPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
        }

        private void InitializeTask(TaskItem? task)
        {
            if (task != null)
            {
                Task = task;
                LoadTask();
                Text = "Editar tarea";
                btnSave.Text = "Editar";
            }
            else
            {
                Task = new TaskItem
                {
                    Status = TaskStatus.Pendiente,
                    Priority = TaskPriority.Media,
                    DueDate = DateTime.Today,
                    IsActive = true
                };
                Text = "Nueva tarea";
                btnSave.Text = "Guardar";
            }
        }
        private void LoadTask()
        {
            txtDescription.Text = Task.Description;
            txtUser.Text = Task.User;
            cmbPriority.SelectedItem = Task.Priority;
            dtpDueDate.Value = Task.DueDate;
            txtNotes.Text = Task.Notes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescription.Text) ||string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    MessageBox.Show("Descripción y Usuario son obligatorios");
                    return;
                }

                Task.Description = txtDescription.Text;
                Task.User = txtUser.Text;
                Task.Priority = (TaskPriority)cmbPriority.SelectedItem;
                Task.DueDate = dtpDueDate.Value;
                Task.Notes = txtNotes.Text;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
