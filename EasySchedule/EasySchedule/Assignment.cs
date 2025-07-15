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
    public partial class Assignment : Form
    {
        //รับค่าชื่อและรหัสนศ. จากฟอร์ม 1 (login)
        public Assignment(string user, string stuID)
        {
            InitializeComponent();
            LoadAssignment();
            lblName.Text = user;
            lblStuID.Text = stuID;
        }

        //เมธอดสำหรับโหลดตารางทุกครั้งที่เปืดโปรแกรม/เปลี่ยนฟอร์ม
        private void LoadAssignment()
        {
            string query = "SELECT * FROM assignment";
            DataTable data = AssignmentDatabase.ExecuteQuery(query);
            dgvAssignment.DataSource = data;
        }

        //ปุ่มเพิ่มงาน
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;
            string work = txtWork.Text;
            string points = txtPoints.Text;
            string dueDate = dtpDueDate.Value.ToString("d");
            string dueTime = dtpDueTime.Value.ToString("HH:mm");

            string query = $@"
            INSERT INTO assignment (SubjectName, Work, Points, DueDate, DueTime)
            VALUES ('{subject}','{work}','{points}','{dueDate}','{dueTime}')";
            AssignmentDatabase.ExecuteNonQuery(query);

            MessageBox.Show("เพิ่มงานสำเร็จ");

            txtSubject.Text = "";
            txtPoints.Text = "";
            txtWork.Text = "";
            LoadAssignment();
        }

        //ปุ่มแก้ไขตารางงาน (ป้อนข้อมูลแล้วกด Edit)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAssignment.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAssignment.SelectedRows[0].Cells["AssignmentID"].Value);
                string subject = txtSubject.Text;
                string work = txtWork.Text;
                string points = txtPoints.Text;
                string dueDate = dtpDueDate.Value.ToString("d");
                string dueTime = dtpDueTime.Value.ToString("HH:mm");

                string query = $@"
                UPDATE assignment
                SET SubjectName = '{subject}', Work = '{work}', Points = '{points}', DueDate = '{dueDate}', DueTime = '{dueTime}'
                WHERE AssignmentID = {id}";
                AssignmentDatabase.ExecuteNonQuery(query);

                MessageBox.Show("แก้ไขตารางเรียนสำเร็จ");

                txtSubject.Text = "";
                txtPoints.Text = "";
                txtWork.Text = "";
                LoadAssignment();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการแก้ไข");
            }
        }

        //ปุ่มลบข้อมูล
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAssignment.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAssignment.SelectedRows[0].Cells["AssignmentID"].Value);
                string query = $"DELETE FROM assignment WHERE AssignmentID = {id}";
                AssignmentDatabase.ExecuteNonQuery(query);

                MessageBox.Show("ลบตารางเรียนสำเร็จ");
                LoadAssignment();
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
            string query = $"SELECT * FROM assignment WHERE SubjectName LIKE %{search}%";
            DataTable data = AssignmentDatabase.ExecuteQuery(query);
            dgvAssignment.DataSource = data;
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

        //แท็บเมนูเปลี่ยนไปหน้าฟอร์ม Exam
        private void examDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = lblName.Text;
            string stuID = lblStuID.Text;
            Exam exam = new Exam(user, stuID);

            this.Hide();
            exam.Show();
        }

        //แท็บเมนูสำหรับเปลี่ยนไปฟอร์ม Assignment (ฟอร์มปัจจุบัน)
        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณอยู่ที่นี่แล้ว", "You are Here"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
