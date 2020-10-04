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
        int selectedTeamId = FormPlayerTeam.selectedTeam;
        public FormEditTeam()
        {
            InitializeComponent();
        }

        private void FormEditTeam_Load(object sender, EventArgs e)
        {
            Teams selectedTeam = Teams.SelectTeam(selectedTeamId);

            textBoxTeamId.Text = selectedTeam.Id.ToString();
            textBoxTeamName.Text = selectedTeam.Name;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Teams t = new Teams(int.Parse(textBoxTeamId.Text), textBoxTeamName.Text);
                Teams.EditTeams(t);
                MessageBox.Show("Teams has been edited.", "information");

                FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
                formPlayerTeam.FormPlayerTeam_Load(buttonEdit, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edited. Message Error: " + ex.Message, "error");
            }
        }
    }
}
