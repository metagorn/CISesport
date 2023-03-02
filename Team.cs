using Newtonsoft.Json;
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
    public partial class Team : Form
    {
        List<ClassTeam> listteam = new List<ClassTeam>();
        public Team()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Teams";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listteam, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Teams";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listteam = JsonConvert.DeserializeObject<List<ClassTeam>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (ClassTeam team_ in listteam)
            {
                dataGridView1.Rows.Add(team_.TeamName, team_.Members[0].Name, team_.Members[1].Name, team_.Members[2].Name, team_.Members[3].Name, team_.Members[4].Name);
            }
        }

        private void newTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamRegister tr = new TeamRegister();
            tr.ShowDialog();
            if (tr.DialogResult == DialogResult.OK)
            {
                ClassTeam team = tr.getTeam();
                listteam.Add(team);
                RefreshDataGrid();
            }
        }
    }
}
