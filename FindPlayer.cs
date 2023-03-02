using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISesport
{
    public partial class FindPlayer : Form
    {
        ClassPlayer player;
        public FindPlayer()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach (ClassPlayer player_ in FormAllPlayer.Instance.listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassPlayer pp = FormAllPlayer.Instance.listplayer[dataGridView1.CurrentRow.Index];
            player = pp;
            this.DialogResult = DialogResult.OK;
        }

        public ClassPlayer GetPlayer()
        {
            return player;
        }
    }
}
