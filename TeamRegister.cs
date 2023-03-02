using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISesport
{
    public partial class TeamRegister : Form
    {
        ClassTeam team;
        List<ClassPlayer> listplayer = new List<ClassPlayer>();
        public TeamRegister()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                ClassPlayer player = new ClassPlayer();
                player.Name = "";
                player.LastName = "";
                player.StudentID = "";
                player.Major = "";
                player.GameName = "";
                player.Email = "";
                player.Phone = "";
                player.Age = 0;
                listplayer.Add(player);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string TeamName = tbTeamname.Text;
            team = new ClassTeam();
            team.TeamName = TeamName;
            team.Members = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "Find1")
            {
                FindPlayer(0, tbMember1);
            }
            else if (btn.Name == "Find2")
            {
                FindPlayer(1, tbMember2);
            }
            else if (btn.Name == "Find3")
            {
                FindPlayer(2, tbMember3);
            }
            else if (btn.Name == "Find4")
            {
                FindPlayer(3, tbMember4);
            }
            else if (btn.Name == "Find5")
            {
                FindPlayer(4, tbMember5);
            }
        }
        private void FindPlayer(int index, TextBox textbox)
        {
            FindPlayer fp = new FindPlayer();
            fp.ShowDialog();
            if (fp.DialogResult == DialogResult.OK)
            {
                listplayer[index] = fp.GetPlayer();
                textbox.Text = listplayer[index].Name;
            }
        }

        public ClassTeam getTeam()
        {
            return this.team;
        }
    }
}
