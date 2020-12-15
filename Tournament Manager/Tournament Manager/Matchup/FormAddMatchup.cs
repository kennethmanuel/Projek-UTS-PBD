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

namespace Tournament_Manager.Tournament_Matchup
{
    public partial class FormAddMatchup : Form
    {
        List<Matchups> listMatchup = new List<Matchups>();
        List<Teams> listTeam1 = new List<Teams>();
        List<Teams> listTeam2 = new List<Teams>();

        public FormAddMatchup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string matchupId = textBoxId.Text;
                int matchupRound = int.Parse(textBoxRound.Text);
                DateTime matchupDate = dateTimePickerMatchup.Value;

                Matchups mat = new Matchups(matchupId, matchupRound, matchupDate);
                Matchups.AddMatchup(mat);

                Teams team1 = (Teams)comboBoxTeam1.SelectedItem; 
                Teams team2 = (Teams)comboBoxTeam2.SelectedItem;


                double team1AddScore = double.Parse(textBoxScore1.Text);
                double team2AddScore = double.Parse(textBoxScore2.Text);

                MatchupEntries.Add(mat, team1, team1AddScore);
                MatchupEntries.Add(mat, team2, team2AddScore);

                team1.AddScore(team1AddScore);
                team2.AddScore(team2AddScore);

                MessageBox.Show("Matchup has been Saved", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Matchups cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }

        private void FormAddMatchup_Load(object sender, EventArgs e)
        {
            listTeam1 = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");
            listTeam2 = TournamentEntry.ReadTeam(FormMenu.selectedTournament);

            comboBoxTeam1.DataSource = listTeam1;
            comboBoxTeam2.DataSource = listTeam2;

            comboBoxTeam1.DisplayMember = "Name";
            comboBoxTeam2.DisplayMember = "Name";

            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;

            string newCode = Matchups.GenerateId();
            textBoxId.Text = newCode;
        }
    }
}
