namespace EasySchedule
{
    partial class Schedule
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
            label1 = new Label();
            lblName = new Label();
            dgvSchedule = new DataGridView();
            cmbDay = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSubject = new TextBox();
            txtRoom = new TextBox();
            txtTeacher = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            examDayToolStripMenuItem = new ToolStripMenuItem();
            assignmentsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            addButtonToolStripMenuItem = new ToolStripMenuItem();
            editButtonToolStripMenuItem = new ToolStripMenuItem();
            deleteButtonToolStripMenuItem = new ToolStripMenuItem();
            searchButtonToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblStuID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            label1.TabIndex = 0;
            label1.Text = "Welcome,";
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
            lblName.TabIndex = 1;
            lblName.Text = "<>";
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackgroundColor = Color.FromArgb(223, 214, 75);
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.GridColor = Color.FromArgb(223, 214, 75);
            dgvSchedule.Location = new Point(617, 64);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(615, 303);
            dgvSchedule.TabIndex = 2;
            // 
            // cmbDay
            // 
            cmbDay.BackColor = Color.White;
            cmbDay.FlatStyle = FlatStyle.Flat;
            cmbDay.FormattingEnabled = true;
            cmbDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbDay.Location = new Point(346, 312);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(184, 28);
            cmbDay.TabIndex = 6;
            // 
            // dtpStart
            // 
            dtpStart.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.CalendarMonthBackground = Color.White;
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(348, 398);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(184, 27);
            dtpStart.TabIndex = 7;
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnd.CalendarMonthBackground = Color.White;
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(346, 492);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(184, 27);
            dtpEnd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 12;
            label2.Text = "SubjectID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 362);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 13;
            label3.Text = "Professor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 451);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 14;
            label4.Text = "Room";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(348, 273);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 15;
            label5.Text = "Day";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(346, 358);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 16;
            label6.Text = "Start Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(346, 452);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 17;
            label7.Text = "End Time";
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(254, 203, 210);
            txtSubject.BorderStyle = BorderStyle.None;
            txtSubject.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtSubject.ForeColor = Color.FromArgb(254, 133, 167);
            txtSubject.Location = new Point(91, 311);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(179, 27);
            txtSubject.TabIndex = 3;
            // 
            // txtRoom
            // 
            txtRoom.BackColor = Color.FromArgb(254, 203, 210);
            txtRoom.BorderStyle = BorderStyle.None;
            txtRoom.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtRoom.ForeColor = Color.FromArgb(254, 133, 167);
            txtRoom.Location = new Point(91, 490);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(179, 27);
            txtRoom.TabIndex = 5;
            // 
            // txtTeacher
            // 
            txtTeacher.BackColor = Color.FromArgb(254, 203, 210);
            txtTeacher.BorderStyle = BorderStyle.None;
            txtTeacher.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtTeacher.ForeColor = Color.FromArgb(254, 133, 167);
            txtTeacher.Location = new Point(91, 400);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(179, 27);
            txtTeacher.TabIndex = 4;
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
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, examDayToolStripMenuItem, assignmentsToolStripMenuItem });
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
            // examDayToolStripMenuItem
            // 
            examDayToolStripMenuItem.Name = "examDayToolStripMenuItem";
            examDayToolStripMenuItem.Size = new Size(175, 26);
            examDayToolStripMenuItem.Text = "Exam Date";
            examDayToolStripMenuItem.Click += examDayToolStripMenuItem_Click;
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
            lblStuID.Font = new Font("Nirmala UI", 13.8F);
            lblStuID.ForeColor = SystemColors.ControlText;
            lblStuID.Location = new Point(372, 42);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(46, 31);
            lblStuID.TabIndex = 23;
            lblStuID.Text = "<>";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EasySchedule_schedule_1;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblStuID);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbDay);
            Controls.Add(txtRoom);
            Controls.Add(txtTeacher);
            Controls.Add(txtSubject);
            Controls.Add(dgvSchedule);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private DataGridView dgvSchedule;
        private ComboBox cmbDay;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSubject;
        private TextBox txtRoom;
        private TextBox txtTeacher;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem examDayToolStripMenuItem;
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