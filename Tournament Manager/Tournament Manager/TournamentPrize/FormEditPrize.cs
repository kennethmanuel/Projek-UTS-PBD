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
        List<Prize> listPrize = new List<Prize>();
        List<Tournaments> listTournaments = new List<Tournaments>();
        int selectedPrizeId = FormPrize.selectedPrize;

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Tournaments t = (Tournaments)comboBoxTournamentsName.SelectedItem;
                Prize p = new Prize(int.Parse(textBoxPrizeId.Text), textBoxPrizePlaceName.Text, int.Parse(textBoxPriceAmount.Text), double.Parse(textBoxPrizePercentage.Text), t);
                Prize.EditPrize(p);
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

        private void FormEditPrize_Load(object sender, EventArgs e)
        {
            listTournaments = Tournaments.ReadCombo(FormMenu.selectedTournament);
            Prize selectedPrize = Prize.SelectPrize(selectedPrizeId);

            listPrize = Prize.ReadData(FormMenu.selectedTournament, "");
            listTournaments = Tournaments.ReadCombo(FormMenu.selectedTournament);
            comboBoxTournamentsName.DataSource = listTournaments;
            comboBoxTournamentsName.DisplayMember = "Name";

            comboBoxTournamentsName.DropDownStyle = ComboBoxStyle.DropDownList;

            string newId = Prize.GenerateCode();
            textBoxPrizeId.Text = newId;
            textBoxPrizeId.Enabled = false;
            comboBoxTournamentsName.Enabled = false;
            textBoxPriceAmount.Text = selectedPrize.PrizeAmount.ToString();
            textBoxPrizePercentage.Text = selectedPrize.PrizePercentage.ToString();
            textBoxPrizePlaceName.Text = selectedPrize.PlaceName;
            textBoxPrizePlaceName.Focus();
        }
    }
}
