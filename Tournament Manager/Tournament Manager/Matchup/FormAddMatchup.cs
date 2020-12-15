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
            //try
            //{
            //    Matchups mat = new Matchups(id, round);
            //    Matchups.AddMatchup(mat);

            //    MatchupEntries entr1 = new MatchupEntries(mat, team1, score1);
            //    MatchupEntries entr2 = new MatchupEntries(mat, team2, score2);

            //    MatchupEntries.add(entr1);
            //    MatchupEntries.add(entr2);
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void FormAddMatchup_Load(object sender, EventArgs e)
        {
            listMatchup = Matchups.ReadData(FormMenu.selectedTournament, "");

            comboBoxTeam1.DataSource = listMatchup;
            comboBoxTeam2.DataSource = listMatchup;

            comboBoxTeam1.DisplayMember = "Name";
            comboBoxTeam2.DisplayMember = "Name";

            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTeam1.DropDownStyle = ComboBoxStyle.DropDownList;

            string newCode = Matchups.GenerateId();
        }
    }
}
