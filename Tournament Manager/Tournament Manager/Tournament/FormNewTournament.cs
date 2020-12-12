using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    public partial class FormNewTournament : Form
    {
        public FormNewTournament()
        {
            InitializeComponent();
        }

        private void ButtonCreateTournament_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate new tournament id
                int newCode = Tournaments.GenerateCode();

                // Create tournament 
                Tournaments newTournament = new Tournaments(newCode, textBoxTournamentName.Text, decimal.Parse(textBoxEntryFee.Text), 1);

                // Add tournament to db
                Tournaments.AddTournament(newTournament);

                // Load selected tournament
                FormTournament formTournament = (FormTournament)this.Owner;
                formTournament.selectedTournament = newTournament;
                this.Hide(); 
                formTournament.buttonLoadTournament_Click(buttonCreateTournament, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tournament cannot be created: " + ex.Message, "Error");
            }
        }

        private void FormNewTournament_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Get back to FormTournament
            this.Owner.Show();
        }
    }
}
