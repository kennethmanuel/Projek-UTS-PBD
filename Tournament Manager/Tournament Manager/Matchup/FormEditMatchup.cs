using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Manager.Match;
using TournamentClassLibrary;

namespace Tournament_Manager.Tournament_Matchup
{
    public partial class FormEditMatchup : Form
    {
        List<Matchups> listMatchup = new List<Matchups>();
        List<Teams> listTeam1 = new List<Teams>();
        List<Teams> listTeam2 = new List<Teams>();

        public FormEditMatchup()
        {
            InitializeComponent();
        }

        private void FormEditMatchup_Load(object sender, EventArgs e)
        {
            listTeam1 = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");
            listTeam2 = TournamentEntry.ReadTeam(FormMenu.selectedTournament);

            comboBoxTeam1.DataSource = listTeam1;
            comboBoxTeam2.DataSource = listTeam2;

            comboBoxTeam1.DisplayMember = "Name";
            comboBoxTeam2.DisplayMember = "Name";

            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Show Data
            textBoxId.Text = FormMatch.selectedMatchup.Id;
            textBoxRound.Text = FormMatch.selectedMatchup.Round.ToString();
            dateTimePickerMatchup.Value = FormMatch.selectedMatchup.Date;

            int team1Id = FormMatch.selectedMatchupEntry1.Team.Id;
            string team1Name = "";
            double team1Score = 0;
            foreach(Teams team in listTeam1)
            {
                if(team.Id == team1Id)
                {
                    team1Name = team.Name;
                    team1Score = team.TotalScore;
                }
            }
            comboBoxTeam1.SelectedIndex = comboBoxTeam1.FindStringExact(team1Name);
            textBoxScore1.Text = FormMatch.selectedMatchupEntry1.Score.ToString();

            int team2Id = FormMatch.selectedMatchupEntry2.Team.Id;
            string team2Name = "";
            double team2Score = 0;
            foreach(Teams team in listTeam2)
            {
                if(team.Id == team2Id)
                {
                    team2Name = team.Name;
                    team2Score = team.TotalScore;
                }
            }
            comboBoxTeam2.SelectedIndex = comboBoxTeam2.FindStringExact(team2Name);
            textBoxScore2.Text = FormMatch.selectedMatchupEntry2.Score.ToString();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string matchupId = textBoxId.Text;
                int matchupRound = int.Parse(textBoxRound.Text);
                DateTime matchupDate = dateTimePickerMatchup.Value;

                Matchups matchup = new Matchups(matchupId, matchupRound, matchupDate);
                Matchups.EditMatchup(matchup);

                Teams team1 = (Teams)comboBoxTeam1.SelectedItem;
                Teams team2 = (Teams)comboBoxTeam2.SelectedItem;

                double team1NewEntryScore = double.Parse(textBoxScore1.Text);
                double team2NewEntryScore = double.Parse(textBoxScore2.Text);

                MatchupEntries.Edit(matchup, team1, team1NewEntryScore);
                MatchupEntries.Edit(matchup, team2, team2NewEntryScore);

                double oldTeam1EntryScore = FormMatch.selectedMatchupEntry1.Score;
                double oldTeam2EntryScore = FormMatch.selectedMatchupEntry2.Score;

                team1.SubstractScore(oldTeam1EntryScore);
                team2.SubstractScore(oldTeam2EntryScore);

                team1.AddScore(team1NewEntryScore);
                team2.AddScore(team2NewEntryScore);

                MessageBox.Show("Matchup has been Saved", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to edit matchup, " + ex.Message, "Error");
            }
        }
    }
}
