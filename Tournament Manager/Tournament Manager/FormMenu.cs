using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Manager.Match;

namespace Tournament_Manager
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void teamAndPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlayerTeam form = new FormPlayerTeam();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatch form = new FormMatch();
            form.Owner = this;
            this.Hide();
            form.ShowDialog();
        }
    }
}
