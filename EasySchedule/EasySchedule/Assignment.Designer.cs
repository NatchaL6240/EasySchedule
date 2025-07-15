namespace EasySchedule
{
    partial class Assignment
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpDueTime = new DateTimePicker();
            txtPoints = new TextBox();
            txtWork = new TextBox();
            txtSubject = new TextBox();
            dgvAssignment = new DataGridView();
            lblName = new Label();
            label1 = new Label();
            dtpDueDate = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            examDateToolStripMenuItem = new ToolStripMenuItem();
            assignmentsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            addButtonToolStripMenuItem = new ToolStripMenuItem();
            editButtonToolStripMenuItem = new ToolStripMenuItem();
            deleteButtonToolStripMenuItem = new ToolStripMenuItem();
            searchButtonToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblStuID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssignment).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(58, 184, 194);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(58, 184, 194);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(69, 604);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 36);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(58, 184, 194);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(58, 184, 194);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(196, 604);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 36);
            btnEdit.TabIndex = 39;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(58, 184, 194);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(58, 184, 194);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(326, 604);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 36);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(58, 184, 194);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(58, 184, 194);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(461, 604);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 36);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(81, 124, 225);
            label7.Location = new Point(331, 418);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 36;
            label7.Text = "Due Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(81, 124, 225);
            label5.Location = new Point(332, 327);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 34;
            label5.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(81, 124, 225);
            label4.Location = new Point(74, 451);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 33;
            label4.Text = "Points";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(81, 124, 225);
            label3.Location = new Point(74, 362);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 32;
            label3.Text = "Work Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(81, 124, 225);
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 31;
            label2.Text = "SubjectID";
            // 
            // dtpDueTime
            // 
            dtpDueTime.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDueTime.CalendarMonthBackground = Color.FromArgb(254, 203, 210);
            dtpDueTime.Format = DateTimePickerFormat.Time;
            dtpDueTime.Location = new Point(329, 455);
            dtpDueTime.Name = "dtpDueTime";
            dtpDueTime.Size = new Size(184, 27);
            dtpDueTime.TabIndex = 30;
            // 
            // txtPoints
            // 
            txtPoints.BackColor = Color.FromArgb(142, 186, 222);
            txtPoints.BorderStyle = BorderStyle.None;
            txtPoints.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtPoints.ForeColor = Color.White;
            txtPoints.Location = new Point(91, 490);
            txtPoints.Name = "txtPoints";
            txtPoints.Size = new Size(179, 27);
            txtPoints.TabIndex = 27;
            // 
            // txtWork
            // 
            txtWork.BackColor = Color.FromArgb(142, 186, 222);
            txtWork.BorderStyle = BorderStyle.None;
            txtWork.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtWork.ForeColor = Color.White;
            txtWork.Location = new Point(91, 400);
            txtWork.Name = "txtWork";
            txtWork.Size = new Size(179, 27);
            txtWork.TabIndex = 26;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(142, 186, 222);
            txtSubject.BorderStyle = BorderStyle.None;
            txtSubject.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtSubject.ForeColor = Color.White;
            txtSubject.Location = new Point(91, 311);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(179, 27);
            txtSubject.TabIndex = 25;
            // 
            // dgvAssignment
            // 
            dgvAssignment.BackgroundColor = Color.FromArgb(165, 193, 255);
            dgvAssignment.BorderStyle = BorderStyle.None;
            dgvAssignment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignment.GridColor = Color.FromArgb(223, 214, 75);
            dgvAssignment.Location = new Point(617, 64);
            dgvAssignment.Name = "dgvAssignment";
            dgvAssignment.RowHeadersWidth = 51;
            dgvAssignment.Size = new Size(615, 303);
            dgvAssignment.TabIndex = 24;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Nirmala UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ControlText;
            lblName.Location = new Point(198, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(72, 50);
            lblName.TabIndex = 23;
            lblName.Text = "<>";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Nirmala UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(194, 50);
            label1.TabIndex = 22;
            label1.Text = "Welcome,";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDueDate.CalendarMonthBackground = Color.White;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(329, 364);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(184, 27);
            dtpDueDate.TabIndex = 41;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 42;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, examDateToolStripMenuItem, assignmentsToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(175, 26);
            scheduleToolStripMenuItem.Text = "Schedule";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // examDateToolStripMenuItem
            // 
            examDateToolStripMenuItem.Name = "examDateToolStripMenuItem";
            examDateToolStripMenuItem.Size = new Size(175, 26);
            examDateToolStripMenuItem.Text = "Exam Date";
            examDateToolStripMenuItem.Click += examDateToolStripMenuItem_Click;
            // 
            // assignmentsToolStripMenuItem
            // 
            assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            assignmentsToolStripMenuItem.Size = new Size(175, 26);
            assignmentsToolStripMenuItem.Text = "Assignments";
            assignmentsToolStripMenuItem.Click += assignmentsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addButtonToolStripMenuItem, editButtonToolStripMenuItem, deleteButtonToolStripMenuItem, searchButtonToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // addButtonToolStripMenuItem
            // 
            addButtonToolStripMenuItem.Name = "addButtonToolStripMenuItem";
            addButtonToolStripMenuItem.Size = new Size(184, 26);
            addButtonToolStripMenuItem.Text = "Add Button";
            addButtonToolStripMenuItem.Click += addButtonToolStripMenuItem_Click;
            // 
            // editButtonToolStripMenuItem
            // 
            editButtonToolStripMenuItem.Name = "editButtonToolStripMenuItem";
            editButtonToolStripMenuItem.Size = new Size(184, 26);
            editButtonToolStripMenuItem.Text = "Edit Button";
            editButtonToolStripMenuItem.Click += editButtonToolStripMenuItem_Click;
            // 
            // deleteButtonToolStripMenuItem
            // 
            deleteButtonToolStripMenuItem.Name = "deleteButtonToolStripMenuItem";
            deleteButtonToolStripMenuItem.Size = new Size(184, 26);
            deleteButtonToolStripMenuItem.Text = "Delete Button";
            deleteButtonToolStripMenuItem.Click += deleteButtonToolStripMenuItem_Click;
            // 
            // searchButtonToolStripMenuItem
            // 
            searchButtonToolStripMenuItem.Name = "searchButtonToolStripMenuItem";
            searchButtonToolStripMenuItem.Size = new Size(184, 26);
            searchButtonToolStripMenuItem.Text = "Search Button";
            searchButtonToolStripMenuItem.Click += searchButtonToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.BackColor = Color.Transparent;
            lblStuID.FlatStyle = FlatStyle.Flat;
            lblStuID.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStuID.ForeColor = SystemColors.ControlText;
            lblStuID.Location = new Point(372, 42);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(46, 31);
            lblStuID.TabIndex = 43;
            lblStuID.Text = "<>";
            // 
            // Assignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EasySchedule_assignment_1;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblStuID);
            Controls.Add(dtpDueDate);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDueTime);
            Controls.Add(txtPoints);
            Controls.Add(txtWork);
            Controls.Add(txtSubject);
            Controls.Add(dgvAssignment);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Assignment";
            Text = "Assignment";
            ((System.ComponentModel.ISupportInitialize)dgvAssignment).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDueTime;
        private TextBox txtPoints;
        private TextBox txtWork;
        private TextBox txtSubject;
        private DataGridView dgvAssignment;
        private Label lblName;
        private Label label1;
        private DateTimePicker dtpDueDate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem examDateToolStripMenuItem;
        private ToolStripMenuItem assignmentsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem addButtonToolStripMenuItem;
        private ToolStripMenuItem editButtonToolStripMenuItem;
        private ToolStripMenuItem deleteButtonToolStripMenuItem;
        private ToolStripMenuItem searchButtonToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblStuID;
    }
}