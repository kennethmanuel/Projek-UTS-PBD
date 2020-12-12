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
using Tournament_Manager.Player_and_Team.Team;
using Tournament_Manager.Team;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormPlayerTeam : Form
    {
        #region Globalvar
        // Teamlist for team datagridview, data loaded at FormLoad
        List<Teams> teamList = new List<Teams>();

        // Playerlist for player datagridview, data loaded at FormLoad
        List<Players> playerList = new List<Players>();

        // Selected player when button edit or delete clicked, data loaded at FormLoad
        public static int selectedPlayer;

        // Selected team when button edit or delete clicked, data loaded at FormLoad
        public static int selectedTeamId;
        #endregion

        #region Functions
        // Player DatagridFormat
        private void FormatDataGridPlayers()
        {
            dataGridViewPlayer.Columns.Clear();
            dataGridViewPlayer.Columns.Add("Id", "Id");
            dataGridViewPlayer.Columns.Add("Name", "Name");
            dataGridViewPlayer.Columns.Add("Email", "Email");
            dataGridViewPlayer.Columns.Add("Team_Id", "Team_Id");
            dataGridViewPlayer.Columns.Add("Name", "Name");
            dataGridViewPlayer.Columns.Add("TotalScore", "Total Score");
        }

        // Show data to datagridplayer
        private void ShowDataGridPlayers()
        {
            // if playerList have player
            if(playerList.Count >0)
            {
                dataGridViewPlayer.Rows.Clear();
                foreach(Players p in playerList)
                {
                    dataGridViewPlayer.Rows.Add(p.Id, p.Name, p.Email, p.Team.Id, p.Team.Name, p.Team.TotalScore);
                }
            }
            // playerlist doesn't have any player
            else
            {
                dataGridViewPlayer.DataSource = null;
            }
        }

        // Show data to datagridteams
        private void ShowDataGridTeams()
        {
            if(teamList.Count >0)
            {
                dataGridViewTeam.DataSource = teamList;
            }
            else
            {
                dataGridViewTeam.DataSource = null;
            }
        }
        #endregion

        #region FormControl
        public FormPlayerTeam()
        {
            InitializeComponent();
        }

        private void FormPlayerTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show FormMenu when FormPlayerTeam closed
            this.Owner.Show();
        }

        public void FormPlayerTeam_Load(object sender, EventArgs e)
        {
            // Get data from db
            teamList = TournamentEntry.ReadTeam(FormMenu.selectedTournament);

            // Show data to datagridteams
            ShowDataGridTeams();

            // Get player data from db
            playerList = TournamentEntry.ReadPlayer(FormMenu.selectedTournament);

            // Format datagridplayer
            FormatDataGridPlayers();

            // Show data to datagridplayer
            ShowDataGridPlayers();
        }

        #region Player
        private void TextBoxSearchPlayer_TextChanged(object sender, EventArgs e)
        {
            // Get texboxsearch
            string playerSearchCriteria = textBoxSearchPlayer.Text;

            // Player search query with criteria
            playerList = TournamentEntry.ReadPlayer(FormMenu.selectedTournament, playerSearchCriteria);

            // Refresh datagridplayer
            ShowDataGridPlayers();
        }

        // Open FormAddPlayer
        private void ButtonAddPlayer_Click(object sender, EventArgs e)
        {
            FormAddPlayer frm = new FormAddPlayer();
            frm.Owner = this;
            frm.ShowDialog();
        }

        // Open FormDeletePlayer
        private void ButtonDeletePlayer_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewPlayer.CurrentCell.RowIndex;

            selectedPlayer = (int)dataGridViewPlayer.Rows[selectedIndex].Cells[0].Value;

            FormDeletePlayer frm = new FormDeletePlayer();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void ButtonEditPlayer_Click(object sender, EventArgs e)
        {
            // selected index from datagridview
            int selectedIndex = dataGridViewPlayer.CurrentCell.RowIndex;
            selectedPlayer = (int)dataGridViewPlayer.Rows[selectedIndex].Cells[0].Value;

            FormEditPlayer frm = new FormEditPlayer();
            frm.Owner = this;
            frm.Show();
        }
        #endregion

        #region team
        private void TextBoxSearchTeam_TextChanged(object sender, EventArgs e)
        {
            // Get texboxsearch
            string teamSearchCriteria = textBoxSearchTeam.Text;

            // Team search query with criteria
            teamList = TournamentEntry.ReadTeam(FormMenu.selectedTournament, teamSearchCriteria);

            // Refresh datagridteam
            ShowDataGridTeams();
        }

        // Open FormEditTeam
        private void ButtonEditTeam_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewTeam.CurrentCell.RowIndex;
            selectedTeamId = (int)dataGridViewTeam.Rows[selectedIndex].Cells[0].Value;

            FormEditTeam frm = new FormEditTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        // Open FormDeleteTeam
        private void ButtonDeleteTeam_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewTeam.CurrentCell.RowIndex;
            selectedTeamId = (int)dataGridViewTeam.Rows[selectedIndex].Cells[0].Value;

            FormDeleteTeam frm = new FormDeleteTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }

        // Open FormAddTeam
        private void ButtonAddTeam_Click(object sender, EventArgs e)
        {
            FormAddTeam frm = new FormAddTeam();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void buttonEditPoin_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewTeam.CurrentCell.RowIndex;
            selectedTeamId = (int)dataGridViewTeam.Rows[selectedIndex].Cells[0].Value;

            FormEditPoint frm = new FormEditPoint();
            frm.Owner = this;
            frm.ShowDialog();
        }
        #endregion

        #endregion


    }
}
