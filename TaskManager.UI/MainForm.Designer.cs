namespace TaskManager.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            groupBox1 = new GroupBox();
            rdbFinished = new RadioButton();
            rdbInProcess = new RadioButton();
            rdbPending = new RadioButton();
            rdbAll = new RadioButton();
            dtpFrom = new DateTimePicker();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.AllowUserToAddRows = false;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { Id, Description, User, Priority, colStatus, DueDate, Notes });
            dataGridViewTasks.Location = new Point(1, 158);
            dataGridViewTasks.MultiSelect = false;
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.ReadOnly = true;
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(1185, 453);
            dataGridViewTasks.TabIndex = 0;
            dataGridViewTasks.CellClick += dataGridViewTasks_CellClick;
            dataGridViewTasks.SelectionChanged += dataGridViewTasks_SelectionChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Descripción";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // User
            // 
            User.DataPropertyName = "User";
            User.HeaderText = "Usuario";
            User.MinimumWidth = 6;
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 125;
            // 
            // Priority
            // 
            Priority.DataPropertyName = "Priority";
            Priority.HeaderText = "Prioridad";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            Priority.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Estado";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // DueDate
            // 
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Fecha Entrega";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            DueDate.Width = 125;
            // 
            // Notes
            // 
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notas";
            Notes.MinimumWidth = 6;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(18, 635);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 70);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(341, 635);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(183, 70);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1003, 635);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 70);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = SystemColors.ActiveCaption;
            btnChangeStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnChangeStatus.ForeColor = Color.White;
            btnChangeStatus.Location = new Point(662, 635);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(183, 70);
            btnChangeStatus.TabIndex = 4;
            btnChangeStatus.Text = "Cambiar estado";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(985, 140);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de búsqueda";
            // 
            // rdbFinished
            // 
            rdbFinished.AutoSize = true;
            rdbFinished.Location = new Point(452, 38);
            rdbFinished.Name = "rdbFinished";
            rdbFinished.Size = new Size(118, 24);
            rdbFinished.TabIndex = 3;
            rdbFinished.Text = "Terminada";
            rdbFinished.UseVisualStyleBackColor = true;
            rdbFinished.CheckedChanged += rdbFinished_CheckedChanged;
            // 
            // rdbInProcess
            // 
            rdbInProcess.AutoSize = true;
            rdbInProcess.Location = new Point(292, 38);
            rdbInProcess.Name = "rdbInProcess";
            rdbInProcess.Size = new Size(127, 24);
            rdbInProcess.TabIndex = 2;
            rdbInProcess.Text = "En Proceso";
            rdbInProcess.UseVisualStyleBackColor = true;
            rdbInProcess.CheckedChanged += rdbInProcess_CheckedChanged;
            // 
            // rdbPending
            // 
            rdbPending.AutoSize = true;
            rdbPending.Location = new Point(136, 38);
            rdbPending.Name = "rdbPending";
            rdbPending.Size = new Size(113, 24);
            rdbPending.TabIndex = 1;
            rdbPending.Text = "Pendiente";
            rdbPending.UseVisualStyleBackColor = true;
            rdbPending.CheckedChanged += rdbPending_CheckedChanged;
            // 
            // rdbAll
            // 
            rdbAll.AutoSize = true;
            rdbAll.Checked = true;
            rdbAll.Location = new Point(27, 32);
            rdbAll.Name = "rdbAll";
            rdbAll.Size = new Size(81, 24);
            rdbAll.TabIndex = 0;
            rdbAll.TabStop = true;
            rdbAll.Text = "Todos";
            rdbAll.UseVisualStyleBackColor = true;
            rdbAll.CheckedChanged += rdbAll_CheckedChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFrom.Location = new Point(15, 29);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(340, 27);
            dtpFrom.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFrom);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(618, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 71);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Desde:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtpTo);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(618, 85);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(361, 67);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta:";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpTo.Location = new Point(9, 26);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(346, 27);
            dtpTo.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ActiveCaption;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1015, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(149, 81);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbAll);
            groupBox4.Controls.Add(rdbPending);
            groupBox4.Controls.Add(rdbInProcess);
            groupBox4.Controls.Add(rdbFinished);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(6, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(594, 81);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Estado tarea:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 721);
            Controls.Add(btnSearch);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnChangeStatus);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewTasks);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto Administrador de tareas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnChangeStatus;
        private GroupBox groupBox1;
        private RadioButton rdbFinished;
        private RadioButton rdbInProcess;
        private RadioButton rdbPending;
        private RadioButton rdbAll;
        private DateTimePicker dtpFrom;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Notes;
        private GroupBox groupBox4;
    }
}