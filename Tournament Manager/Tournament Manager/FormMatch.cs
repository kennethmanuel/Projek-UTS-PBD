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
        List<Matchups> matchupList = new List<Matchups>();
        List<MatchupEntries> entryList = new List<MatchupEntries>();
        
        public FormMatch()
        {
            InitializeComponent();
        }

        private void Matchup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void FormatDataGridMatchup()
        {
            dataGridViewMatchup.Columns.Add("Id", "Id");
            dataGridViewMatchup.Columns.Add("WinnerId", "WinnerId");
            dataGridViewMatchup.Columns.Add("WinnerTeam", "WinnerTeam");
            dataGridViewMatchup.Columns.Add("Round", "Round");
        }

        private void ShowDataGridMatchup()
        {
            if(matchupList.Count > 0)
            {
                dataGridViewMatchup.Rows.Clear();
                foreach(Matchups m in matchupList)
                {
                    dataGridViewMatchup.Rows.Add(m.Id, m.WinnerTeam.Id, m.WinnerTeam.Name, m.Round);
                }
            }
            else
            {
                dataGridViewMatchup.DataSource = null;
            }
        }


        private void FormMatch_Load(object sender, EventArgs e)
        {
            FormatDataGridMatchup();
            matchupList = Matchups.ReadData("", "");
            ShowDataGridMatchup();
        }
    }
}
