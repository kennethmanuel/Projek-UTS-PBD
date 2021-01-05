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
    public partial class FormAddTeam : Form
    {
        public FormAddTeam()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teams t = new Teams(int.Parse(textBoxTeamId.Text), textBoxTeamName.Text, 0);
                Teams.AddTeams(t, FormMenu.selectedTournament);
                MessageBox.Show("Team has been Saved", "information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Team cannot be Saved. Error Message: " + ex.Message, "error");
            }
        }

        private void FormAddTeam_Load(object sender, EventArgs e)
        {
            string newCode = Teams.GenerateCode();

            textBoxTeamId.Text = newCode;
            textBoxTeamId.Enabled = false;
            textBoxTeamName.Focus();
        }

        private void FormAddTeam_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
            formPlayerTeam.FormPlayerTeam_Load(formPlayerTeam, e);
            this.Close();
        }
    }
}
