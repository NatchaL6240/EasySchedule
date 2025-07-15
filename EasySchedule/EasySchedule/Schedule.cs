using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySchedule
{
    public partial class Schedule : Form
    {
        //รับค่าชื่อและรหัสนศ. จากฟอร์ม 1 (login)
        public Schedule(string user, string stuID)
        {
            InitializeComponent();
            LoadSchedule();
            lblName.Text = user;
            lblStuID.Text = stuID;
        }

        //เมธอดสำหรับโหลกตารางทุกครั้งที่ที่เปืดโปรแกรม/ฟอร์ม
        private void LoadSchedule()
        {
            string query = "SELECT * FROM Schedules";
            DataTable data = ScheduleDatabase.ExecuteQuery(query);
            dgvSchedule.DataSource = data;

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        //ปุ่มเพิ่มวิชาเรียน
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            string teacher = txtTeacher.Text;
            string room = txtRoom.Text;
            string day = cmbDay.SelectedItem.ToString();
            string startTime = dtpStart.Value.ToString("HH:mm");
            string endTime = dtpEnd.Value.ToString("HH:mm");

            string query = $@"
            INSERT INTO Schedules (SubjectName, Teacher, Room, DayOfWeek, StartTime, EndTime)
            VALUES ('{subject}','{teacher}','{room}','{day}','{startTime}','{endTime}')";
            ScheduleDatabase.ExecuteNonQuery(query);

            MessageBox.Show("เพิ่มตารางเรียนสำเร็จ");

            txtSubject.Text = "";
            txtTeacher.Text = "";
            txtRoom.Text = "";

            LoadSchedule();
        }

        //ปุ่มแก้ไขตารางเรียน (ป้อนข้อมูลแล้วกด Edit)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSchedule.SelectedRows[0].Cells["ScheduleID"].Value);
                string subject = txtSubject.Text;
                string teacher = txtTeacher.Text;
                string room = txtRoom.Text;
                string day = cmbDay.SelectedItem.ToString();
                string startTime = dtpStart.Value.ToString("HH:mm");
                string endTime = dtpEnd.Value.ToString("HH:mm");

                string query = $@"
                UPDATE Schedules
                SET SubjectName = '{subject}', Teacher = '{teacher}', Room = '{room}', DayOfWeek = '{day}', 
                StartTime = '{startTime}', EndTime = '{endTime}'
                WHERE ScheduleID = {id}";
                ScheduleDatabase.ExecuteNonQuery(query);

                MessageBox.Show("แก้ไขตารางเรียนสำเร็จ");

                txtSubject.Text = "";
                txtTeacher.Text = "";
                txtRoom.Text = "";
                LoadSchedule();
            }
            else
            {
                MessageBox.Show("กรุณาาแถวที่ต้องการแก้ไข");
            }
        }

        //ปุ่มลบข้อมูล
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSchedule.SelectedRows[0].Cells["ScheduleID"].Value);
                string query = $"DELETE FROM Schedules WHERE ScheduleID = {id}";
                ScheduleDatabase.ExecuteNonQuery(query);

                MessageBox.Show("ลยตารางเรียนสำเร็จ");
                LoadSchedule();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ");
            }
        }

        //ปุ่มค้นหาวิชาเรียน จากรหัสวิชา
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSubject.Text;
            string query = $"SELECT * FROM Schedules WHERE SubjectName LIKE '%{search}%'";
            DataTable data = ScheduleDatabase.ExecuteQuery(query);
            dgvSchedule.DataSource = data;
        }

        //แท็บเมนูเปลี่ยนไปหน้าฟอร์ม Exam
        private void examDayToolStripMenuItem_Click(object sender, EventArgs e) //ปัญหาเรื่องชื่อ
        {
            string user = lblName.Text;
            string stuID = lblStuID.Text;
            Exam exam = new Exam(user,stuID);

            this.Hide();
            exam.Show();

        }

        //แท็ปเมนูสำหรับเปลี่ยนไปฟอร์ม Schedule (ฟอร์มปัจจุบัน)
        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณอยู่ที่นี่แล้ว", "You are Here"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //แท็ปเมนูเปลี่ยนไปหน้าฟอร์ม Assignment
        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = lblName.Text;
            string stuID = lblStuID.Text;
            Assignment assignment = new Assignment(user,stuID);

            this.Hide();
            assignment.Show();
        }

        //แท็บเมนูออกจากโปรแกรม
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการออกหรือไม่?", "Exit"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //แท็บอธิบายปุ่ม Add
        private void addButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เพิ่มข้อมูลในตาราง", "Add Button"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //แท็บอธิบายปุ่ม Edit
        private void editButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("แก้ไขข้อมูลในตารางจากข้อมูลที่กรอกไว้ (เลือกช่องลูกศรซ้ายสุด)", "Edit Button"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //แท็บอธิบายปุ่ม Delete
        private void deleteButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ลบข้อมูลที่บันทึกไว้ทั้งแถว (เลือกช่องลูกศรซ้ายสุด)", "Delete Button"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //แท็บอธิบาย Search
        private void searchButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ค้นหาข้อมูลของวิชานั้นๆจากรหัสวิชา", "Search Button"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
