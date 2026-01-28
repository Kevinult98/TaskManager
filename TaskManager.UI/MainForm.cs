using System;
using System.Collections.Generic;
using TaskManager.ViewModels.Tasks;
using TaskManager.Data.Repositories;
using TaskManager.Data.Database;
using TaskManager.Domain.Entities;
using TaskStatus = TaskManager.Domain.Enums.TaskStatus;
using TaskManager.UI.Helpers;


namespace TaskManager.UI
{
    public partial class MainForm : Form
    {
        private TaskViewModel _viewModel;
        public MainForm()
        {
            InitializeComponent();

            ConfigureGrid();
            InitializeViewModel();
            LoadTasks();
        }

        private void InitializeViewModel()
        {
            try
            {
                string connectionString = "Data Source=taskmanager.db";

                var connectionFactory = new SqliteConnectionFactory(connectionString);
                connectionFactory.InitializeDatabase();

                var repository = new TaskRepository(connectionFactory);
                _viewModel = new TaskViewModel(repository);
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void ConfigureGrid()
        {
            dataGridViewTasks.AutoGenerateColumns = false;
            CenterGridColumns();
            HideInternalColumns();
            FormatDateColumns();
        }

        private void CenterGridColumns()
        {
            foreach (DataGridViewColumn column in dataGridViewTasks.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void HideInternalColumns()
        {
            if (dataGridViewTasks.Columns.Contains("isActive"))
            {
                dataGridViewTasks.Columns["isActive"].Visible = false;
            }
        }
        private void FormatDateColumns()
        {
            if (dataGridViewTasks.Columns.Contains("DueDate"))
            {
                dataGridViewTasks.Columns["DueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void LoadTasks()
        {
            try
            {
                dataGridViewTasks.DataSource = null;
                dataGridViewTasks.DataSource = _viewModel.Tasks;
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new TaskForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.AddTask(form.Task);
                    LoadTasks();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var task = _viewModel.SelectedTask;

                if (task == null)
                    return;

                if (task.Status != TaskStatus.Pendiente)
                {
                    MessageBox.Show("Solo se pueden editar tareas en estado Pendiente.","Edición no permitida",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                using var form = new TaskForm(task);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.UpdateTask(form.Task);
                    LoadTasks();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var task = _viewModel.SelectedTask;

                if (task == null)
                    return;

                if (task.Status == TaskStatus.EnProceso)
                {
                    MessageBox.Show(
                        "No se pueden eliminar tareas en proceso.",
                        "Eliminación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (task.Status == TaskStatus.Terminada)
                {
                    MessageBox.Show(
                        "No se pueden eliminar tareas finalizadas.",
                        "Eliminación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                var confirm = MessageBox.Show(
                    "¿Desea eliminar esta tarea pendiente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                _viewModel.DeleteTask(task);
                LoadTasks();
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void dataGridViewTasks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTasks.CurrentRow?.DataBoundItem is TaskItem task)
                {
                    _viewModel.SelectedTask = task;
                }
                else
                {
                    _viewModel.SelectedTask = null;
                }

                UpdateButtons();
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (_viewModel.SelectedTask == null)
                {
                    return;
                }                
                _viewModel.ChangeStatus(_viewModel.SelectedTask);
                LoadTasks();
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void UpdateButtons()
        {
            try
            {
                var task = _viewModel.SelectedTask;

                if (task == null)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnChangeStatus.Enabled = false;
                    return;
                }

                btnEdit.Enabled = task.Status == TaskStatus.Pendiente;
                btnDelete.Enabled = task.Status == TaskStatus.Pendiente;
                btnChangeStatus.Enabled = task.Status != TaskStatus.Terminada;
                ApplyButtonStyle(btnEdit);
                ApplyButtonStyle(btnChangeStatus);
            }
            catch (Exception ex)
            {

                ErrorHandler.Handle(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bool noStatusFilter = rdbAll.Checked;
                bool noDateFilter = !dtpFrom.Checked && !dtpTo.Checked;

                if (noStatusFilter && noDateFilter)
                {
                    _viewModel.LoadTasks();
                }
                else
                {
                    TaskStatus? status = null;

                    if (rdbPending.Checked)
                    {
                        status = TaskStatus.Pendiente;
                    }
                    else if (rdbInProcess.Checked)
                    {
                        status = TaskStatus.EnProceso;
                    }
                    else if (rdbFinished.Checked)
                    {
                        status = TaskStatus.Terminada;
                    }


                    if (dtpFrom.Checked && dtpTo.Checked &&
                        dtpFrom.Value.Date > dtpTo.Value.Date)
                    {
                        MessageBox.Show(
                            "La fecha de inicio no puede ser mayor que la fecha final.",
                            "Rango de fechas inválido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    DateTime? from = dtpFrom.Checked ? dtpFrom.Value.Date : null;
                    DateTime? to = dtpTo.Checked ? dtpTo.Value.Date : null;

                    _viewModel.ApplyAdvancedFilter(status, from, to);

                }

                dataGridViewTasks.DataSource = null;
                dataGridViewTasks.DataSource = _viewModel.Tasks;

                dataGridViewTasks.ClearSelection();
                _viewModel.SelectedTask = null;
                UpdateButtons();

                if (_viewModel.Tasks == null || !_viewModel.Tasks.Any())
                {
                    MessageBox.Show(
                        "No se encontraron resultados con los filtros seleccionados.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void rdbFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbFinished.Checked) return;
            rdbAll.Checked = false;
        }

        private void rdbInProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbInProcess.Checked) return;
            rdbAll.Checked = false;
        }

        private void rdbPending_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbPending.Checked) return;
            rdbAll.Checked = false;
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbAll.Checked) return;

            rdbPending.Checked = false;
            rdbInProcess.Checked = false;
            rdbFinished.Checked = false;
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewTasks.Rows[e.RowIndex].Selected = true;
            }
        }

        private void ApplyButtonStyle(Button button)
        {
            if (button.Enabled)
            {
                button.BackColor = SystemColors.ActiveCaption;
                button.ForeColor = Color.White;
            }
            else
            {
                button.BackColor = Color.IndianRed;
                button.ForeColor = Color.White;
            }

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}
