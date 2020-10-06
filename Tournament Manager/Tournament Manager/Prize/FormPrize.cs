using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Manager.TournamentPrize;
using TournamentClassLibrary;

namespace Tournament_Manager
{
    //MASIH SALAH
    public partial class FormPrize : Form
    {
        List<Prize> listPrize = new List<Prize>();
        public static int selectedPrize;
        public FormPrize()
        {
            InitializeComponent();
        }

        public void FormPrize_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listPrize = Prize.ReadData(FormMenu.selectedTournament, "");
            ViewDataGrid();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string criteria = textBoxSearch.Text;
            listPrize = Prize.ReadData(FormMenu.selectedTournament,criteria);
            ViewDataGrid();
        }

        private void buttonAddPrice_Click(object sender, EventArgs e)
        {
            FormAddPrize frm = new FormAddPrize();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonEditPrize_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewPrize.CurrentCell.RowIndex;
            selectedPrize = (int)dataGridViewPrize.Rows[selectedIndex].Cells[0].Value;
            FormEditPrize frm = new FormEditPrize();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDeletePrize_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewPrize.CurrentCell.RowIndex;
            selectedPrize = (int)dataGridViewPrize.Rows[selectedIndex].Cells[0].Value;

            FormDeletePrize frm = new FormDeletePrize();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void FormatDataGrid()
        {
            dataGridViewPrize.Columns.Clear();

            dataGridViewPrize.Columns.Add("Id", "Id");
            dataGridViewPrize.Columns.Add("PlaceName", "Place Name");
            dataGridViewPrize.Columns.Add("PrizeAmount", "Prize Amount");
            dataGridViewPrize.Columns.Add("PricePercentage", "Price Percentage");
            dataGridViewPrize.Columns.Add("Tournaments_Id", "Tournament Id");           

            dataGridViewPrize.Columns["PrizeAmount"].DefaultCellStyle.Format = "#,###";
        }
        private void ViewDataGrid()
        {
            dataGridViewPrize.Rows.Clear();

            if (listPrize.Count > 0)
            {
                foreach (Prize p in listPrize)
                {
                    dataGridViewPrize.Rows.Add(p.Id, p.PlaceName, p.PrizeAmount, p.PrizePercentage, p.Tournament.Id);
                }
            }
            else
            {
                dataGridViewPrize.DataSource = null;
            }
        }

        private void FormPrize_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
