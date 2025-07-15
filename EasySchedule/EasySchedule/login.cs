using System.Windows.Forms;

namespace EasySchedule
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //ปุ่มเข้าสู้หน้าฟอร์ม 2 (Schedule) และส่งข้อมูลชื่อและรหัสนักศึกษาให้กับฟอร์มที่รับค่า
        //เช็คว่า textbox รับต่าชื่อ รหัสนศ. ว่าว่างหรือไม่ หากว่างให้ขึ้น Messagebox 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string stuID = txtStudentID.Text;

            if (user == "")
            {
                MessageBox.Show("กรุณาป้อนชื่อ", "Blank Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (stuID == "")
            {
                MessageBox.Show("กรุณาป้อนรหัสนักศึกษา", "Blank StudentID",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (pass == "")
            {
                MessageBox.Show("กรุณาป้อนรหัสผ่าน", "Blank Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Schedule schedule = new Schedule(user, stuID);
                schedule.Show();

                this.Hide();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //แท็บหน้าชื่อผู้ทำ
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6606058 ณัชชา เลิศสกุลชล" + "\n" + "6606515 ศศิพร ไชยอังคาร", "ชื่อผู้สร้าง"
                , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //แท็บหน้าออกจากโปรแกรม
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการออกหรือไม่?", "Exit"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
