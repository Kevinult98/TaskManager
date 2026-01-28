namespace TaskManager.UI
{
    partial class TaskForm
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
            txtDescription = new TextBox();
            txtUser = new TextBox();
            cmbPriority = new ComboBox();
            dtpDueDate = new DateTimePicker();
            txtNotes = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(156, 32);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(345, 27);
            txtDescription.TabIndex = 0;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(117, 100);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(384, 27);
            txtUser.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(129, 147);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(220, 37);
            cmbPriority.TabIndex = 2;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDueDate.Location = new Point(14, 36);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(382, 27);
            dtpDueDate.TabIndex = 3;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(6, 26);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(483, 150);
            txtNotes.TabIndex = 4;
            txtNotes.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(32, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 56);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(313, 481);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 56);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 182);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 8;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 159);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 10;
            label3.Text = "Prioridad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpDueDate);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(18, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 72);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fecha Finalización:";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 549);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbPriority);
            Controls.Add(txtUser);
            Controls.Add(txtDescription);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "TaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tareas";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtUser;
        private ComboBox cmbPriority;
        private DateTimePicker dtpDueDate;
        private RichTextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
    }
}