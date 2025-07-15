using System.Windows.Forms;

namespace EasySchedule
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //����������˹�ҿ���� 2 (Schedule) ����觢����Ū���������ʹѡ�֡�����Ѻ���������Ѻ���
        //����� textbox �Ѻ��Ҫ��� ���ʹ�. �����ҧ������� �ҡ��ҧ����� Messagebox 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string stuID = txtStudentID.Text;

            if (user == "")
            {
                MessageBox.Show("��سһ�͹����", "Blank Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (stuID == "")
            {
                MessageBox.Show("��سһ�͹���ʹѡ�֡��", "Blank StudentID",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else if (pass == "")
            {
                MessageBox.Show("��سһ�͹���ʼ�ҹ", "Blank Password",
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

        //��˹�Ҫ��ͼ���
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6606058 �Ѫ�� ����ʡ�Ū�" + "\n" + "6606515 ��Ծ� ���ѧ���", "���ͼ�����ҧ"
                , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //��˹���͡�ҡ�����
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("��ͧ����͡�������?", "Exit"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
