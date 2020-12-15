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
                Matchups mat = new Matchups(textBoxId.Text, int.Parse(textBoxRound.Text));
                Matchups.AddMatchup(mat);

                Teams team1 = (Teams)comboBoxTeam1.SelectedItem; 
                Teams team2 = (Teams)comboBoxTeam2.SelectedItem;
                
                MatchupEntries.Add(mat, team1, double.Parse(textBoxScore1.Text));
                MatchupEntries.Add(mat, team2, double.Parse(textBoxScore2.Text));

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
