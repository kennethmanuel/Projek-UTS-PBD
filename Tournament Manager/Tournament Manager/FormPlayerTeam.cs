using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Manager.Player;
using Tournament_Manager.Team;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormPlayerTeam : Form
    {
        List<Teams> teamList = new List<Teams>();
        List<Players> playerList = new List<Players>();
        public static int selectedPlayer;
        public static int selectedTeam;
        
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
            dataGridViewPlayer.Columns.Clear();
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

        public void FormPlayerTeam_Load(object sender, EventArgs e)
        {
            //Team
            teamList = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            if(teamList.Count >0)
            {
                dataGridViewTeam.DataSource = teamList;
            }
            else
            {
                dataGridViewTeam.DataSource = null;
            }

            //Player
            FormatDataGridPlayers();
            playerList = TournamentEntry.ReadPlayer(FormMenu.selectedTournament, "");
            ShowDataGridPlayers();
        }

        private void textBoxSearchPlayer_TextChanged(object sender, EventArgs e)
        {
            string criteria = textBoxSearchPlayer.Text;
            playerList = TournamentEntry.ReadPlayer(FormMenu.selectedTournament, criteria);
            ShowDataGridPlayers();
        }

        private void textBoxSearchTeam_TextChanged(object sender, EventArgs e)
        {
            teamList = TournamentEntry.ReadTeam(FormMenu.selectedTournament, textBoxSearchTeam.Text);

            if(teamList.Count > 0)
            {
                dataGridViewTeam.DataSource = teamList;
            }
            else
            {
                dataGridViewTeam.DataSource = null;
            }
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            FormAddTeam frm = new FormAddTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            FormAddPlayer frm = new FormAddPlayer();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            FormDeletePlayer frm = new FormDeletePlayer();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonEditPlayer_Click(object sender, EventArgs e)
        {
            // selected index from datagridview
            int selectedIndex = dataGridViewPlayer.CurrentCell.RowIndex;
            selectedPlayer = (int)dataGridViewPlayer.Rows[selectedIndex].Cells[0].Value;

            FormEditPlayer frm = new FormEditPlayer();
            frm.Owner = this;
            frm.Show();
            
        }

        private void buttonEditTeam_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewTeam.CurrentCell.RowIndex;
            selectedTeam = (int)dataGridViewTeam.Rows[selectedIndex].Cells[0].Value;

            FormEditTeam frm = new FormEditTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewTeam.CurrentCell.RowIndex;
            selectedTeam = (int)dataGridViewTeam.Rows[selectedIndex].Cells[0].Value;

            FormDeleteTeam frm = new FormDeleteTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedPlayer.ToString());
        }
    }
}
