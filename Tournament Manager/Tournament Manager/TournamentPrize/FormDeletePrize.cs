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
    public partial class FormDeletePrize : Form
    {
        List<Prize> listPrize = new List<Prize>();
        int selectedPrizeId = FormPrize.selectedPrize;


        public FormDeletePrize()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data prize akan terhapus , Apakah anda yakin?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                
                Tournaments tournaments = (Tournaments)comboBoxTournamentsName.SelectedItem;
                Prize p = new Prize(int.Parse(textBoxPrizeId.Text), textBoxPrizePlaceName.Text, int.Parse(textBoxPriceAmount.Text), double.Parse(textBoxPrizePercentage.Text),tournaments);
                string add = Prize.DeletePrize(p);
                if (add == "1")
                {
                    MessageBox.Show("Prize has been deleted.", "information");
                    FormPlayerTeam frm = (FormPlayerTeam)this.Owner;
                    frm.FormPlayerTeam_Load(buttonDelete, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Prize Failed to deleted. Message error: ", add);
                }
            }
        }

        private void FormDeletePrize_Load(object sender, EventArgs e)
        {
          // Prize selectedPrize = Prize.SelectPrize(selectedPrizeId);

           //textBoxPrizeId.Text = selectedPrize.Id.ToString();
            //textBoxPrizePlaceName.Text = selectedPrize.PlaceName;
          
            //comboBoxTournamentsName.Text = selectedPrize.Tournament.Name;
        }
    }
}
