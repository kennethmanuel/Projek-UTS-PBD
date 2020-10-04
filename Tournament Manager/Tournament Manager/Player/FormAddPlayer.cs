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
    public partial class FormAddPlayer : Form
    {
        List<Teams> listteam = new List<Teams>();
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            listteam = Teams.ReadData("", "");
            comboBoxTeam.DataSource = listteam;
            comboBoxTeam.DisplayMember = "Name";
            comboBoxTeam.DropDownStyle = ComboBoxStyle.DropDownList;

            string newCode = Players.GenerateCode();

            textBoxPlayerId.Text = newCode;
            textBoxPlayerId.Enabled = false;
            textBoxPlayerName.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teams team = (Teams)comboBoxTeam.SelectedItem;
                Players p = new Players(int.Parse(textBoxPlayerId.Text), textBoxPlayerName.Text, textBoxPlayerEmail.Text, team);
                Players.AddPlayer(p);
                MessageBox.Show("Player has been Saved", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Player cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAddPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPlayerTeam frm = (FormPlayerTeam)this.Owner;
            frm.FormPlayerTeam_Load(buttonAdd, e);
            this.Close();
        }
    }
}
