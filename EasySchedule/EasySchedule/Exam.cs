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
    public partial class Exam : Form
    {
        //รับค่าชื่อและรหัสนศ. จากฟอร์ม 1 (login)
        public Exam(string user, string stuID)
        {
            InitializeComponent();
            LoadExam();
            lblName.Text = user;
            lblStuID.Text = stuID;
        }

        private void Exam_Load(object sender, EventArgs e)
        {

        }

        //เมธอดสำหรับโหลดตารางทุกครั้งที่เปืดโปรแกรม/เปลี่ยนฟอร์ม
        private void LoadExam()
        {
            string query = "SELECT * FROM exams";
            DataTable data = ExamDatabase.ExecuteQuery(query);
            dgvExam.DataSource = data;
        }

        //ปุ่มเพิ่มวันสอบ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            string day = dtpDate.Value.ToString();
            string seat = txtSeat.Text;
            string room = txtRoom.Text;
            string startTime = dtpStart.Value.ToString("HH:mm");
            string endTime = dtpEnd.Value.ToString("HH:mm");

            string query = $@"
            INSERT INTO exams (SubjectName, ExamDate, Room, Seat, StartTime, EndTime)
            VALUES ('{subject}', '{day}', '{room}', '{seat}','{startTime}','{endTime}')";
            ExamDatabase.ExecuteNonQuery(query);

            MessageBox.Show("เพิ่มวันสอบสำเร็จ");

            txtSubject.Text = "";
            txtSeat.Text = "";
            txtRoom.Text = "";
            LoadExam();
        }

        //ปุ่มแก้ไขตารางงาน (ป้อนข้อมูลแล้วกด Edit)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvExam.SelectedRows[0].Cells["ExamID"].Value);
                string subject = txtSubject.Text;
                string day = dtpDate.Value.ToString("d");
                string seat = txtSeat.Text;
                string room = txtRoom.Text;
                string startTime = dtpStart.Value.ToString("HH:mm");
                string endTime = dtpEnd.Value.ToString("HH:mm");

                string query = $@"
                UPDATE exams
                SET SubjectName = '{subject}', ExamDate = '{day}', Room = '{room}', Seat = '{seat}', 
                StartTime = '{startTime}', EndTime = '{endTime}'
                WHERE ExamID = {id}";
                ExamDatabase.ExecuteNonQuery(query);

                MessageBox.Show("แก้ไขวันสอบสำเร็จ");

                txtSubject.Text = "";
                txtSeat.Text = "";
                txtRoom.Text = "";
                LoadExam();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการแก้ไข");
            }
        }

        //ปุ่มลบข้อมูล
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvExam.SelectedRows[0].Cells["ExamID"].Value);
                string query = $"DELETE FROM exams WHERE ExamID = {id}";
                ExamDatabase.ExecuteNonQuery(query);

                MessageBox.Show("ลบตารางเรียนสำเร็จ");
                LoadExam();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ");
            }
        }

        //ปุ่มหาข้อมูลงาน จากรหัสวิชา
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSubject.Text;
            string query = $"SELECT * FROM exams WHERE SubjectName LIKE %{search}%";
            DataTable data = ExamDatabase.ExecuteQuery(query);
            dgvExam.DataSource = data;
        }

        //แท็บเมนูเปลี่ยนไปหน้าฟอร์ม Schedule
        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = lblName.Text;
            string stuID = lblStuID.Text;
            Schedule schedule = new Schedule(user, stuID);

            this.Hide();
            schedule.Show();
        }

        //แท็บเมนูสำหรับเปลี่ยนไปฟอร์ม Exam (ฟอร์มปัจจุบัน)
        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณอยู่ที่นี่แล้ว", "You are Here"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //แท็ปเมนูเปลี่ยนไปหน้าฟอร์ม Assignment
        private void assignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = lblName.Text;
            string stuID = lblStuID.Text;
            Assignment assignment = new Assignment(user, stuID);

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
