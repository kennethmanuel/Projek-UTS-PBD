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

namespace Tournament_Manager.Team
{
    public partial class FormEditTeam : Form
    {
        List<Teams> listteams = new List<Teams>();
        public FormEditTeam()
        {
            InitializeComponent();
        }

        private void FormEditTeam_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Teams t = new Teams(int.Parse(textBoxTeamId.Text), textBoxTeamName.Text);
                Teams.EditTeams(t);
                MessageBox.Show("Teams has been edited.", "information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edited. Message Error: " + ex.Message, "error");
            }
        }

        private void textBoxTeamId_TextChanged(object sender, EventArgs e)
        {
            listteams = Teams.ReadData("Id", textBoxTeamId.Text);

            if (listteams.Count > 0)
            {
                textBoxTeamName.Text = listteams[0].Name;
                textBoxTeamName.Focus();
            }
            else
            {
                MessageBox.Show("Team Id is not found.", "error");
                textBoxTeamName.Text = "";
            }
        }
    }
}
