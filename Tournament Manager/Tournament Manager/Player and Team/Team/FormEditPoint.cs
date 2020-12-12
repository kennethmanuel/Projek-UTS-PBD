using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager.Player_and_Team.Team
{
    public partial class FormEditPoint : Tournament_Manager.Tournament_Matchup.FormAddMatchup
    {
        List<Teams> listteams = new List<Teams>();
        int selectedTeamId = FormPlayerTeam.selectedTeamId;
        public FormEditPoint()
        {
            InitializeComponent();
        }

        private void FormEditPoint_Load(object sender, EventArgs e)
        {
            Teams selectedTeam = Teams.SelectTeam(selectedTeamId);
            textBoxTeamId.Enabled = false;
            textBoxTeamName.Enabled = false;

            textBoxTeamId.Text = selectedTeam.Id.ToString();
            textBoxTeamName.Text = selectedTeam.Name;
            textBoxTeamPoint.Text = selectedTeam.TotalScore.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Teams t = new Teams(int.Parse(textBoxTeamId.Text), textBoxTeamName.Text, double.Parse(textBoxTeamPoint.Text));
                Teams.EditPoint(t);
                MessageBox.Show("Teams Point has been  edited.", "information");

                FormPlayerTeam form = (FormPlayerTeam)this.Owner;
                form.FormPlayerTeam_Load(buttonEdit, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to edited. Message Error: " + ex.Message, "error");
            }
        }
    }
}
