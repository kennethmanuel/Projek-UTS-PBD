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
        // list available team
        List<Teams> listTeams = new List<Teams>();

        // list selected team
        int selectedTeamId = FormPlayerTeam.selectedTeamId;

        public FormDeleteTeam()
        {
            InitializeComponent();
        }

        private void FormDeleteTeam_Load(object sender, EventArgs e)
        {
            // create team object based on selected teamid
            Teams selectedTeam = Teams.SelectTeam(selectedTeamId);

            // match selected control with the newly created team object
            textBoxTeamId.Text = selectedTeam.Id.ToString();
            textBoxTeamName.Text = selectedTeam.Name;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Team will be deleted. Are you sure?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == System.Windows.Forms.DialogResult.Yes)
            {
                bool delete = Teams.DeleteTeams(selectedTeamId, out string errorMessage);

                if (delete)
                {
                    MessageBox.Show("Team has been deleted.", "information");
                }
                else
                {
                    MessageBox.Show("Team Failed to deleted. Message error: " +  errorMessage);
                }

                // Open form playerteam and close form delete team
                FormPlayerTeam formPlayerTeam = (FormPlayerTeam)this.Owner;
                formPlayerTeam.FormPlayerTeam_Load(buttonDelete, e);
                this.Close();
            }
        }
    }
}
