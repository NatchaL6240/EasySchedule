namespace EasySchedule
{
    partial class Exam
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
            lblName = new Label();
            label1 = new Label();
            dgvExam = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            txtRoom = new TextBox();
            txtSubject = new TextBox();
            dtpDate = new DateTimePicker();
            txtSeat = new TextBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            examToolStripMenuItem = new ToolStripMenuItem();
            assignmentToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            addButtonToolStripMenuItem = new ToolStripMenuItem();
            editButtonToolStripMenuItem = new ToolStripMenuItem();
            deleteButtonToolStripMenuItem = new ToolStripMenuItem();
            searchButtonToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            lblStuID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            lblName.TabIndex = 3;
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
            label1.TabIndex = 2;
            label1.Text = "Welcome,";
            // 
            // dgvExam
            // 
            dgvExam.BackgroundColor = Color.FromArgb(133, 202, 208);
            dgvExam.BorderStyle = BorderStyle.None;
            dgvExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam.GridColor = Color.FromArgb(223, 214, 75);
            dgvExam.Location = new Point(617, 64);
            dgvExam.Name = "dgvExam";
            dgvExam.RowHeadersWidth = 51;
            dgvExam.Size = new Size(615, 303);
            dgvExam.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(58, 184, 194);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(58, 184, 194);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(68, 604);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 36);
            btnAdd.TabIndex = 37;
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
            btnEdit.Location = new Point(195, 604);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(89, 36);
            btnEdit.TabIndex = 36;
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
            btnDelete.Location = new Point(325, 604);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 36);
            btnDelete.TabIndex = 35;
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
            btnSearch.Location = new Point(460, 604);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 36);
            btnSearch.TabIndex = 34;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(91, 179, 204);
            label7.Location = new Point(345, 452);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 33;
            label7.Text = "End Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(91, 179, 204);
            label6.Location = new Point(345, 358);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 32;
            label6.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(91, 179, 204);
            label5.Location = new Point(348, 273);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 31;
            label5.Text = "Exam Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(91, 179, 204);
            label4.Location = new Point(73, 451);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 30;
            label4.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(91, 179, 204);
            label3.Location = new Point(74, 362);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 29;
            label3.Text = "Seat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(91, 179, 204);
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 28;
            label2.Text = "SubjectID";
            // 
            // dtpEnd
            // 
            dtpEnd.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnd.CalendarMonthBackground = Color.White;
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(346, 492);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(184, 27);
            dtpEnd.TabIndex = 27;
            // 
            // dtpStart
            // 
            dtpStart.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.CalendarMonthBackground = Color.White;
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(347, 399);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(184, 27);
            dtpStart.TabIndex = 26;
            // 
            // txtRoom
            // 
            txtRoom.BackColor = Color.FromArgb(117, 196, 204);
            txtRoom.BorderStyle = BorderStyle.None;
            txtRoom.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtRoom.ForeColor = Color.White;
            txtRoom.Location = new Point(91, 490);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(179, 27);
            txtRoom.TabIndex = 24;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.FromArgb(117, 196, 204);
            txtSubject.BorderStyle = BorderStyle.None;
            txtSubject.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtSubject.ForeColor = Color.White;
            txtSubject.Location = new Point(91, 311);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(179, 27);
            txtSubject.TabIndex = 22;
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.CalendarMonthBackground = Color.White;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(345, 308);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(184, 27);
            dtpDate.TabIndex = 38;
            // 
            // txtSeat
            // 
            txtSeat.BackColor = Color.FromArgb(117, 196, 204);
            txtSeat.BorderStyle = BorderStyle.None;
            txtSeat.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            txtSeat.ForeColor = Color.White;
            txtSeat.Location = new Point(91, 399);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(179, 27);
            txtSeat.TabIndex = 39;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, helpToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 40;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleToolStripMenuItem, examToolStripMenuItem, assignmentToolStripMenuItem });
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
            // examToolStripMenuItem
            // 
            examToolStripMenuItem.Name = "examToolStripMenuItem";
            examToolStripMenuItem.Size = new Size(175, 26);
            examToolStripMenuItem.Text = "Exam Date";
            examToolStripMenuItem.Click += examToolStripMenuItem_Click;
            // 
            // assignmentToolStripMenuItem
            // 
            assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            assignmentToolStripMenuItem.Size = new Size(175, 26);
            assignmentToolStripMenuItem.Text = "Assignments";
            assignmentToolStripMenuItem.Click += assignmentToolStripMenuItem_Click;
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
            lblStuID.TabIndex = 41;
            lblStuID.Text = "<>";
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.EasySchedule_exam_1;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblStuID);
            Controls.Add(txtSeat);
            Controls.Add(dtpDate);
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
            Controls.Add(txtRoom);
            Controls.Add(txtSubject);
            Controls.Add(dgvExam);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Exam";
            Text = "Exam";
            Load += Exam_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label label1;
        private DataGridView dgvExam;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private TextBox txtRoom;
        private TextBox txtSubject;
        private DateTimePicker dtpDate;
        private TextBox txtSeat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem examToolStripMenuItem;
        private ToolStripMenuItem assignmentToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem addButtonToolStripMenuItem;
        private ToolStripMenuItem editButtonToolStripMenuItem;
        private ToolStripMenuItem deleteButtonToolStripMenuItem;
        private ToolStripMenuItem searchButtonToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label lblStuID;
    }
}