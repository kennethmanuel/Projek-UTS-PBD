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
            dataGridViewMatchup.Columns.Add("TeamId", "TeamId");
            dataGridViewMatchup.Columns.Add("TeamName", "TeamName");
            dataGridViewMatchup.Columns.Add("Round", "Round");
        }
        private void FormatDataGridMatchupEntries()
        {
            dataGridViewEntry.Columns.Add("ParentMatchup_Id", "ParentMatchupId");
            dataGridViewEntry.Columns.Add("Round", "Round");          
        }

        private void ShowDataGridMatchup()
        {
            if (matchupList.Count > 0)
            {
                dataGridViewMatchup.Rows.Clear();
                foreach (Matchups m in matchupList)
                {
                    dataGridViewMatchup.Rows.Add(m.Id,  m.Round);
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
                foreach (MatchupEntries e in entryList)
                {
                    dataGridViewEntry.Rows.Add(e.Matchup.Id, e.Team.Id, e.Score, e.Matchup.Round, e.Team.Name);
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
            matchupList = Matchups.ReadData(FormMenu.selectedTournament,"");            
            ShowDataGridMatchup();
            
            //Menampilkan Data dari database tabel matchupEntries
            FormatDataGridMatchupEntries();
            entryList = MatchupEntries.ReadData();
            ShowDataGridMatchupEntries();
        }

        private void ButtonNewMatchup_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchMatchup_TextChanged(object sender, EventArgs e)
        {
            // Get texboxsearch
            string matchupSearchCriteria = textBoxSearchMatchup.Text;

            // Player search query with criteria
            matchupList = Matchups.ReadData(FormMenu.selectedTournament, matchupSearchCriteria);

            // Refresh datagridplayer
            ShowDataGridMatchup();
        }
    }
}
