using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormPlayerTeam : Form
    {
        List<Teams> teamList = new List<Teams>();
        List<Players> playerList = new List<Players>();
        public FormPlayerTeam()
        {
            InitializeComponent();
        }

        private void FormPlayerTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void FormatDataGridPlayers()
        {
            dataGridViewPlayer.Columns.Add("Id", "Id");
            dataGridViewPlayer.Columns.Add("Name", "Name");
            dataGridViewPlayer.Columns.Add("Email", "Email");
            dataGridViewPlayer.Columns.Add("Team_Id", "Team_Id");
        }

        private void ShowDataGridPlayers()
        {
            if(playerList.Count >0)
            {
                dataGridViewPlayer.Rows.Clear();
                foreach(Players p in playerList)
                {
                    dataGridViewPlayer.Rows.Add(p.Id, p.Name, p.Email, p.Team.Name);
                }
            }
            else
            {
                dataGridViewPlayer.DataSource = null;
            }
        }

        private void FormPlayerTeam_Load(object sender, EventArgs e)
        {
            teamList = Teams.ReadData("", "");

            if(teamList.Count > 0)
            {
                dataGridViewTeam.DataSource = teamList;
            }
            else
            {
                dataGridViewTeam.DataSource = null;
            }

            FormatDataGridPlayers();
            playerList = Players.ReadData("", "");
            ShowDataGridPlayers();
        }

        private void textBoxSearchPlayer_TextChanged(object sender, EventArgs e)
        {
            string criteria = textBoxSearchPlayer.Text;
            playerList = Players.BatchSearch(criteria);
            ShowDataGridPlayers();
        }

        private void textBoxSearchTeam_TextChanged(object sender, EventArgs e)
        {
            teamList = Teams.BatchSearch(textBoxSearchTeam.Text);

            if(teamList.Count > 0)
            {
                dataGridViewTeam.DataSource = teamList;
            }
            else
            {
                dataGridViewTeam.DataSource = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddTeam frm = new FormAddTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAddPlayer frm = new FormAddPlayer();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
