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
    public partial class FormPairing : Form
    {
        public FormPairing()
        {
            InitializeComponent();
        }

        private void FormPairing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Teams> listTeam = TournamentEntry.ReadTeam(FormMenu.selectedTournament);

            List<Pairing> listPair =  Pairing.GeneratePairing(listTeam);

            string test = Pairing.TestPairing(listPair);

            MessageBox.Show(test);


        }
    }
}
