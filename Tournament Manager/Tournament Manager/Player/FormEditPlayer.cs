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
    public partial class FormEditPlayer : Form
    {
        List<Players> listPlayers = new List<Players>();
        List<Teams> listTeams = new List<Teams>();
        public FormEditPlayer()
        {
            InitializeComponent();
        }

        private void FormEditPlayer_Load(object sender, EventArgs e)
        {
            listTeams = Teams.ReadData("", "");

            comboBoxTeam.DataSource = listPlayers;
            comboBoxTeam.DisplayMember = "Name";            
        }

        private void textBoxPlayerId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
