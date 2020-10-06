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

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            try
            {
                int newCode = Tournaments.GenerateCode();
                Tournaments t = new Tournaments(newCode, textBoxTournamentName.Text, decimal.Parse(textBoxEntryFee.Text));
                Tournaments.AddTournament(t);

                FormTournament form = (FormTournament)this.Owner;
                form.selectedTournament = t;

                this.Hide();

                form.buttonLoadTournament_Click(buttonCreateTournament, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tournament cannot be created: " + ex.Message, "Error");
            }
        }

        private void FormNewTournament_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();

        }
    }
}
