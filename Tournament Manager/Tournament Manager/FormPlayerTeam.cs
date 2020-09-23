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
    public partial class FormPlayerTeam : Form
    {
        public List<Players> playerList = new List<Players>();
        public FormPlayerTeam()
        {
            InitializeComponent();
        }

        private void FormPlayerTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void FormPlayerTeam_Load(object sender, EventArgs e)
        {
            
        }
    }
}
