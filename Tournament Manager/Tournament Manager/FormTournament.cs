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
        List<Tournaments> listTournament = new List<Tournaments>();
        public Tournaments selectedTournament;
        public FormTournament()
        {
            InitializeComponent();
        }

        private void FormTournament_Load(object sender, EventArgs e)
        {
            listTournament = Tournaments.ReadData();
            if (listTournament.Count > 0)
            {
                comboBoxTournament.DataSource = listTournament;
                comboBoxTournament.DisplayMember = "Name";
            }
        }

        private void buttonLoadTournament_Click(object sender, EventArgs e)
        {
            selectedTournament = (Tournaments)comboBoxTournament.SelectedItem;

            FormMenu form = new FormMenu();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }
    }
}
