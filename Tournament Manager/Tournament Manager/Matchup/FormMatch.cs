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
        #endregion

        #region Function
        private void FormatDataGridMatchup()
        {
            dataGridViewMatchup.Columns.Add("Id", "Id");
            dataGridViewMatchup.Columns.Add("WinnerId", "WinnerId");
            dataGridViewMatchup.Columns.Add("WinnerTeam", "WinnerTeam");
            dataGridViewMatchup.Columns.Add("Round", "Round");
        }
        private void FormatDataGridMatchupEntries()
        {
            dataGridViewEntry.Columns.Add("ParentMatchup_Id", "ParentMatchupId");
            dataGridViewEntry.Columns.Add("TeamsId", "TeamsId");
            dataGridViewEntry.Columns.Add("score", "Score");
            dataGridViewEntry.Columns.Add("Round", "Round");
            dataGridViewEntry.Columns.Add("name", "Name");
        }

        private void ShowDataGridMatchup()
        {
            if (matchupList.Count > 0)
            {
                dataGridViewMatchup.Rows.Clear();
                foreach (Matchups m in matchupList)
                {
                    dataGridViewMatchup.Rows.Add(m.Id, m.WinnerTeam.Id, m.WinnerTeam.Name, m.Round);
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
            matchupList = Matchups.ReadData();            
            ShowDataGridMatchup();
            
            //Menampilkan Data dari database tabel matchupEntries
            FormatDataGridMatchupEntries();
            entryList = MatchupEntries.ReadData();
            ShowDataGridMatchupEntries();
        }

        private void ButtonNewMatchup_Click(object sender, EventArgs e)
        {

        }
    }
}
