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
                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username can't be empty.");
                }
                else if (textBoxServer.Text == "")
                {
                    MessageBox.Show("Server name can't be empty.");
                }
                else if (textBoxDatabase.Text == "")
                {
                    MessageBox.Show("Database name can't be empty.");
                }
                else
                {
                    Connection connection = new Connection(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                    MessageBox.Show("Connection Success.", "Info");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to connect!");
            }
        }
    }
}
