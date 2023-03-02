using Newtonsoft.Json;
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
    public partial class FormAllPlayer : Form
    {
        public static FormAllPlayer Instance;
        public List<ClassPlayer> listplayer = new List<ClassPlayer>();
        public FormAllPlayer()
        {
            InitializeComponent();
            Instance = this;
        }
        private void newPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo fp = new FormInfo();
            fp.ShowDialog();
            if (fp.DialogResult == DialogResult.OK)
            {
                listplayer.Add(fp.getPlayer());
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (ClassPlayer player_ in listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.StudentID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        private void openPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Players";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listplayer = JsonConvert.DeserializeObject<List<ClassPlayer>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Players";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listplayer, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Team tm = new Team();
            tm.ShowDialog();
        }
    }
}
