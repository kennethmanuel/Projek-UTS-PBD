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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Username is empty
                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username can't be empty.");
                }
                // Server is empty
                else if (textBoxServer.Text == "")
                {
                    MessageBox.Show("Server name can't be empty.");
                }
                // Database is empty
                else if (textBoxDatabase.Text == "")
                {
                    MessageBox.Show("Database name can't be empty.");
                }
                // All necessarry info fulfilled
                else
                {
                    // Connect to database
                    Connection connection = new Connection(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                    // Hide FormLogin
                    this.Hide();

                    // Show FormTournament
                    FormTournament formTournament = new FormTournament();
                    formTournament.ShowDialog();
                }
            }
            // Login credentials invalid
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to connect!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Temporary login info
            textBoxUsername.Text = "beth";
            textBoxPassword.Text = "harmon";
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "tournament_db";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }
    }
}
