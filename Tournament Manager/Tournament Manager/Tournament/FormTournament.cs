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
    public partial class FormTournament : Form
    {
        // List available tournament to select
        List<Tournaments> listTournament = new List<Tournaments>();

        // Selected tournament (passed onto FormMenu)
        public Tournaments selectedTournament;

        public FormTournament()
        {
            InitializeComponent();
        }

        private void FormTournament_Load(object sender, EventArgs e)
        {
            // Get tournament data from tournament table to listTournament
            listTournament = Tournaments.ReadData();

            // Display tournament name on comboBox
            if (listTournament.Count > 0)
            {
                comboBoxTournament.DataSource = listTournament;
                comboBoxTournament.DisplayMember = "Name";
            }
        }

        public void buttonLoadTournament_Click(object sender, EventArgs e)
        {
            // Get selected 
            if (selectedTournament == null)
            {
                selectedTournament = (Tournaments)comboBoxTournament.SelectedItem;
            }

            FormMenu form = new FormMenu();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            FormNewTournament form = new FormNewTournament();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }
    }
}
