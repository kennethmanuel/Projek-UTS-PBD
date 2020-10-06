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
        List<Players> listPlayers = new List<Players>();
        List<Teams> listTeams = new List<Teams>();
        int selectedPlayerId = FormPlayerTeam.selectedPlayer;
        public FormDeletePlayer()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data player akan terhapus , Apakah anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Teams team = (Teams)comboBoxTeam.SelectedItem;
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);
                string add = Players.DeletePlayer(p);
                if (add == "1")
                {
                    MessageBox.Show("Player has been deleted.", "information");
                    FormPlayerTeam frm = (FormPlayerTeam)this.Owner;
                    frm.FormPlayerTeam_Load(buttonDelete, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Player Failed to deleted. Message error: ", add);
                }
            }
        }

        private void FormDeletePlayer_Load(object sender, EventArgs e)
        {
            listTeams = TournamentEntry.ReadTeam(FormMenu.selectedTournament, "");

            Players selectedPlayer = Players.SelectPlayer(selectedPlayerId);
                       
            textBoxPlayerId.Text = selectedPlayer.Id.ToString();
            textBoxPlayerName.Text = selectedPlayer.Name;
            textBoxPlayerEmail.Text = selectedPlayer.Email;
            comboBoxTeam.Text = selectedPlayer.Team.Name;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
