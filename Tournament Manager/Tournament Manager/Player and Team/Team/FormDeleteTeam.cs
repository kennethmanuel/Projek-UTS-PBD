using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager.Team
{
    public partial class FormDeleteTeam : Form
    {
        List<Teams> listTeams = new List<Teams>();
        int selectedTeamId = FormPlayerTeam.selectedTeam;
        public FormDeleteTeam()
        {
            InitializeComponent();
        }

        private void FormDeleteTeam_Load(object sender, EventArgs e)
        {
            Teams selectedTeam = Teams.SelectTeam(selectedTeamId);

            textBoxTeamId.Text = selectedTeam.Id.ToString();
            textBoxTeamName.Text = selectedTeam.Name;
        }

        private void textBoxTeamId_TextChanged(object sender, EventArgs e)
        {
            listTeams = Teams.ReadData("Id", textBoxTeamId.Text);
            if (listTeams.Count > 0)
            {
                textBoxTeamName.Text = listTeams[0].Name;
                buttonDelete.Focus();
            }
            else
            {
                MessageBox.Show("Team Id is not found.", "Error");
                textBoxTeamName.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Team has been Deleted. Are you sure ?", "confirm", MessageBoxButtons.YesNo);

            if (confirm == System.Windows.Forms.DialogResult.Yes)
            {
                Teams t = new Teams(int.Parse(textBoxTeamId.Text), textBoxTeamName.Text);
                string add = Teams.DeleteTeams(t);

                if (add == "1")
                {
                    MessageBox.Show("Team has been deleted.", "information");
                }
                else
                {
                    MessageBox.Show("Team Failed to deleted. Message error: ", add);
                }

                FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
                formPlayerTeam.FormPlayerTeam_Load(buttonDelete, e);
                this.Close();
            }
        }
    }
}
