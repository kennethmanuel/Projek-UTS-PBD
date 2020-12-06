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
    public partial class FormEditPrize : Form
    {
        public FormEditPrize()
        {
            InitializeComponent();
        }

        private void FormEditPrize_Load(object sender, EventArgs e)
        {
            //Prize selectedPrize = Prize.SelectPrize(FormPrize.selectedPrize);

            //textBoxPrizeId.Text = selectedPrize.Id.ToString();

            //textBoxPriceAmount.Text = selectedPrize.PrizeAmount.ToString();

            //textBoxPrizePercentage.Text = selectedPrize.PrizePercentage.ToString();

            //textBoxPrizePlaceName.Text = selectedPrize.PlaceName;

            textBoxPrizePlaceName.Focus();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Tournaments t = FormMenu.selectedTournament;

                Prize prize = new Prize(
                    int.Parse(textBoxPrizeId.Text),
                    textBoxPrizePlaceName.Text, decimal.Parse(textBoxPriceAmount.Text),
                    double.Parse(textBoxPrizePercentage.Text),
                    FormMenu.selectedTournament);

                Prize.EditPrize(prize);

                MessageBox.Show("Prize has been changed", "Information");

                FormPrize formPrize = (FormPrize)this.Owner;
                formPrize.FormPrize_Load(buttonEdit, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prize cannot be saved. Error Message: " + ex.Message, "Error");
            }
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
    }
}
