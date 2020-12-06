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

namespace Tournament_Manager.TournamentPrize
{
    public partial class FormAddPrize : Form
    {
        List<Prize> listPrize = new List<Prize>();
        List<Tournaments> listTournaments = new List<Tournaments>();
        public FormAddPrize()
        {
            InitializeComponent();
        }

        private void FormAddPrize_Load(object sender, EventArgs e)
        {
            //listPrize = Prize.ReadData(FormMenu.selectedTournament, "");
            listTournaments = Tournaments.ReadCombo(FormMenu.selectedTournament);

            string newId = Prize.GenerateCode();
            textBoxPrizeId.Text = newId;
            textBoxPrizePlaceName.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Prize prize = new Prize(
                    int.Parse(textBoxPrizeId.Text),
                    textBoxPrizePlaceName.Text, decimal.Parse(textBoxPriceAmount.Text),
                    double.Parse(textBoxPrizePercentage.Text),
                    FormMenu.selectedTournament);

                Prize.AddData(prize);

                MessageBox.Show("Prize has been saved", "information");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prize cannot be saved. Error Message: " + ex.Message, "Error");
            }
        }

        private void FormAddPrize_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrize frm = (FormPrize)this.Owner;
            frm.FormPrize_Load(buttonAdd, e);
            this.Close();
        }

        private void textBoxPrizePercentage_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPrizePercentage.Text != "")
            {
                decimal prize = decimal.Parse(textBoxPrizePercentage.Text) * TournamentEntry.CalculateParticipant(FormMenu.selectedTournament) * FormMenu.selectedTournament.Entryfee;

                textBoxPriceAmount.Text = prize.ToString();
                if(double.Parse(textBoxPrizePercentage.Text)>1)
                {
                    MessageBox.Show("Please enter a fraction (value from 0-1)");
                    textBoxPrizePercentage.Clear();
                }
            }
        }

        private void textBoxPriceAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
