using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager.Match
{    
    public partial class FormMatch : Form
    {
        #region GlobalVar
        List<Matchups> matchupList = new List<Matchups>();
        List<MatchupEntries> entryList = new List<MatchupEntries>();
        public static int selectedMatch;
        #endregion

        #region Function
        private void FormatDataGridMatchup()
        {
            dataGridViewMatchup.Columns.Add("Id", "Id");
            dataGridViewMatchup.Columns.Add("Round", "Round");
        }
        private void FormatDataGridMatchupEntries()
        {
            dataGridViewEntry.Columns.Add("ParentMatchup_Id", "ParentMatchupId");
            dataGridViewEntry.Columns.Add("TeamId", "TeamId");
            dataGridViewEntry.Columns.Add("TeamName", "TeamName");
            dataGridViewEntry.Columns.Add("Score", "Score");          
        }

        private void ShowDataGridMatchup()
        {
            if (matchupList.Count > 0)
            {
                dataGridViewMatchup.Rows.Clear();
                foreach (Matchups m in matchupList)
                {
                    dataGridViewMatchup.Rows.Add(m.Id, m.Round);
                }
            }
            else
            {
                dataGridViewMatchup.DataSource = null;
            }
        }

        private void ShowDataGridMatchupEntries()
        {
            if (entryList.Count > 0)
            {
                dataGridViewEntry.Rows.Clear();
                foreach (MatchupEntries matchupentries in entryList)
                {
                    dataGridViewEntry.Rows.Add(matchupentries.Matchup.Id, matchupentries.Team.Id, matchupentries.Team.Name, matchupentries.Score);
                }
            }
            else
            {
                dataGridViewMatchup.DataSource = null;
            }
        }
        #endregion

        public FormMatch()
        {
            InitializeComponent();
        }

        private void Matchup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }       

        private void FormMatch_Load(object sender, EventArgs e)
        {
            //Menampilkan Data dari database tabel matchup
            FormatDataGridMatchup();            
            matchupList = Matchups.ReadData(FormMenu.selectedTournament);            
            ShowDataGridMatchup();
            
            //Menampilkan Data dari database tabel matchupEntries
            FormatDataGridMatchupEntries();
            entryList = MatchupEntries.ReadData(FormMenu.selectedTournament);
            ShowDataGridMatchupEntries();
        }

        private void ButtonNewMatchup_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchMatchup_TextChanged(object sender, EventArgs e)
        {
            // Player search query with criteria
            matchupList = Matchups.ReadData(FormMenu.selectedTournament);

            // Refresh datagridplayer
            ShowDataGridMatchup();
        }

        private void buttonEditMatchup_Click(object sender, EventArgs e)
        {

        }
    }
}
