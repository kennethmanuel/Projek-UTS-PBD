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

namespace Tournament_Manager
{
    public partial class FormEditPlayer : Form
    {
        List<Players> listPlayers = new List<Players>();
        List<Teams> listTeams = new List<Teams>();
        public FormEditPlayer()
        {
            InitializeComponent();
        }

        private void FormEditPlayer_Load(object sender, EventArgs e)
        {
            listTeams = Teams.ReadData("", "");

            comboBoxTeam.DataSource = listTeams;
            comboBoxTeam.DisplayMember = "Name";
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void textBoxPlayerId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            try
            {
                Teams team = (Teams)comboBoxTeam.SelectedItem;
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);
                Players.EditPlayer(p);
                MessageBox.Show("Player has been changed", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Player cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }
    }
}
