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

namespace Tournament_Manager.Player
{
    public partial class FormDeletePlayer : Form
    {
        // Listed team on combobox
        List<Teams> listTeams = new List<Teams>();

        // Selected player to be deleted
        int selectedPlayerId = FormPlayerTeam.selectedPlayer;

        public FormDeletePlayer()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Confirm
            DialogResult konfirmasi = MessageBox.Show("Data player akan terhapus , Apakah anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo);

            // Confirm yes
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Teams team = (Teams)comboBoxTeam.SelectedItem;

                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);

                bool success = Players.DeletePlayer(p, out string exceptionMessage);

                if (success)
                {
                    MessageBox.Show("Player has been deleted.", "information");
                    FormPlayerTeam frm = (FormPlayerTeam)this.Owner;
                    frm.FormPlayerTeam_Load(buttonDelete, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Player Failed to deleted. Message error: " + exceptionMessage);
                }
            }
        }

        private void FormDeletePlayer_Load(object sender, EventArgs e)
        {
            // Get team for combobox
            listTeams = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            // Get selected player to be deleted
            Players selectedPlayer = Players.SelectPlayer(selectedPlayerId);
                       
            // Show selected player to be deleted's data to form
            textBoxPlayerId.Text = selectedPlayer.Id.ToString();
            textBoxPlayerName.Text = selectedPlayer.Name;
            textBoxPlayerEmail.Text = selectedPlayer.Email;
            comboBoxTeam.Text = selectedPlayer.Team.Name;
        }
    }
}
