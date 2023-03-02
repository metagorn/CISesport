using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CISesport
{
    public partial class FormInfo : Form
    {
        ClassPlayer player;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastname.Text;
            string studentid = tbStudentid.Text;
            string mail = tbMail.Text;
            string phone = tbPhone.Text;
            string major = tbMajor.Text;
            string displayname = tbDisplayname.Text;
            int iAge = 0;
            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (Exception ex)
            {
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }

            player = new ClassPlayer()
            {
                Name = name,
                LastName = lastname,
                StudentID = studentid,
                Major = major,
                GameName = displayname,
                Email = mail,
                Phone = phone,
                Age = iAge
            };
            this.DialogResult = DialogResult.OK;

        }
        public ClassPlayer getPlayer() { return player; }
    }
}