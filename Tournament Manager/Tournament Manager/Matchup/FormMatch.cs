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
using Tournament_Manager.Tournament_Matchup;
using TournamentClassLibrary;

namespace Tournament_Manager.Match
{    
    public partial class FormMatch : Form
    {
        #region GlobalVar
        List<Matchups> matchupList = new List<Matchups>();
        List<MatchupEntries> entryList = new List<MatchupEntries>();

        public static Matchups selectedMatchup;
        public static MatchupEntries selectedMatchupEntry1;
        public static MatchupEntries selectedMatchupEntry2;
        #endregion

        #region Function
        private void FormatDataGridMatchup()
        {
            dataGridViewMatchup.Columns.Clear();
            dataGridViewMatchup.Columns.Add("Id", "Id");
            dataGridViewMatchup.Columns.Add("Round", "Round");
            dataGridViewMatchup.Columns.Add("DateTime", "DateTime");
        }
        private void FormatDataGridMatchupEntries()
        {
            dataGridViewEntry.Columns.Clear();
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
                    dataGridViewMatchup.Rows.Add(m.Id, m.Round, m.Date.ToString("yyyy-MM-dd"));
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

        public void FormMatch_Load(object sender, EventArgs e)
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
            int matchupSelectedIndex = dataGridViewMatchup.CurrentCell.RowIndex;
            string selectedMatchupId = dataGridViewMatchup.Rows[matchupSelectedIndex].Cells[0].Value.ToString();

            selectedMatchup = Matchups.SelectMatchup(selectedMatchupId);

            List<MatchupEntries> pair = Matchups.GetEntries(selectedMatchup);
            selectedMatchupEntry1 = pair[0];
            selectedMatchupEntry2 = pair[1];

            FormEditMatchup formEditMatchup = new FormEditMatchup();
            formEditMatchup.Owner = this;
            formEditMatchup.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Matchup akan didelete, Apakah anda yakin?", "Confirm", MessageBoxButtons.YesNo);

            if(confirm == System.Windows.Forms.DialogResult.Yes)
            {
                int matchupSelectedIndex = dataGridViewMatchup.CurrentCell.RowIndex;
                string selectedMatchupId = dataGridViewMatchup.Rows[matchupSelectedIndex].Cells[0].Value.ToString();

                selectedMatchup = Matchups.SelectMatchup(selectedMatchupId);

                List<MatchupEntries> pair = Matchups.GetEntries(selectedMatchup);
                selectedMatchupEntry1 = pair[0];
                selectedMatchupEntry2 = pair[1];

                MatchupEntries.Delete(selectedMatchup, selectedMatchupEntry1.Team);
                MatchupEntries.Delete(selectedMatchup, selectedMatchupEntry2.Team);

                Matchups.DeleteMatchup(selectedMatchup);

                MessageBox.Show("Delete successful.");
            }
            else
            {
                MessageBox.Show("Delete matchup canceled.");
            }
        }

        private void ButtonViewMatchPairing_Click(object sender, EventArgs e)
        {
            FormPairing formPairing = new FormPairing()
            {
                Owner = this
            };
            this.Hide();
            
            formPairing.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddMatchup form = new FormAddMatchup();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
