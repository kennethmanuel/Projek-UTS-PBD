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
                }
                else
                {
                    MessageBox.Show("Player Failed to deleted. Message error: ", add);
                }

            }
        }

        private void FormDeletePlayer_Load(object sender, EventArgs e)
        {

            textBoxPlayerName.Enabled = false;
        }

        private void textBoxPlayerId_TextChanged(object sender, EventArgs e)
        {
            listPlayers = Players.ReadData("Id", textBoxPlayerId.Text);
            if (listTeams.Count > 0)
            {
                textBoxPlayerName.Text = listPlayers[0].Name;
                textBoxPlayerEmail.Text = listPlayers[0].Email;                
                buttonDelete.Focus();
            }
            else
            {
                MessageBox.Show("Player Id is not found.", "Error");
                textBoxPlayerName.Text = "";
            }
        }
    }
}
