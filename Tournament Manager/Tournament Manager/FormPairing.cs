using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentClassLibrary;
using DGVPrinterHelper;
using Tournament_Manager.Tournament_Matchup;

namespace Tournament_Manager
{
    public partial class FormPairing : Form
    {
        List<Teams> listTeam = new List<Teams>();
        List<Pairing> listPair = new List<Pairing>();
        public FormPairing()
        {
            InitializeComponent();
        }
       
      
        private void FormPairing_Load(object sender, EventArgs e)
        {
            listTeam = TournamentEntry.ReadTeam(FormMenu.selectedTournament);
            listPair = Pairing.GeneratePairing(listTeam);
            FormatDataGrid();
            AddPairToDataGrid();
            
        }

        /// <summary>
        /// Format DataGrid
        /// </summary>
        private void FormatDataGrid()
        {
            dataGridViewPair.Columns.Clear();
            dataGridViewPair.Columns.Add("Team1Id", "Team 1 Id");
            dataGridViewPair.Columns.Add("Team1", "Team 1");          
            dataGridViewPair.Columns.Add("", "");           
            dataGridViewPair.Columns.Add("Team2", "Team 2");
            dataGridViewPair.Columns.Add("Team2Id", "Team 2 Id");

            dataGridViewPair.Columns.Add("Round", "Round");
        }

        /// <summary>
        /// Display Data Value Datagrid from database
        /// </summary>
        public void AddPairToDataGrid()
        {
            foreach (Pairing pair in listPair)
            {
                dataGridViewPair.Rows.Add(pair.Team1.Id, pair.Team1.Name, "vs", pair.Team2.Name, pair.Team2.Id, pair.Round);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pairing> pairList = new List<Pairing>();

                for (int rows = 0; rows < dataGridViewPair.Rows.Count; rows++)
                {
                    // ID!!!
                    int team1Id = (int)dataGridViewPair.Rows[rows].Cells["Team1Id"].Value;
                    Teams team1 = Teams.SelectTeam(team1Id);

                    int team2Id = (int)dataGridViewPair.Rows[rows].Cells["Team2Id"].Value;
                    Teams team2 = Teams.SelectTeam(team2Id);

                    // >>>
                    double team1Score = (double)Convert.ToInt32(dataGridViewPair.Rows[rows].Cells["ScoreTeam1"].Value);

                    double team2Score = (double)Convert.ToInt32(dataGridViewPair.Rows[rows].Cells["ScoreTeam2"].Value);

                    int round = (int)dataGridViewPair.Rows[rows].Cells["Round"].Value;

                    Pairing pair = new Pairing(team1, team2, round, team1Score, team2Score);

                    pairList.Add(pair);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = 0;

            int team1Score = Convert.ToInt32(dataGridViewPair.Rows[rows].Cells["ScoreTeam1"].Value);

            MessageBox.Show(team1Score.ToString());

        }

        private void buttonInsertMatchup_Click(object sender, EventArgs e)
        {
            FormAddMatchup form = new FormAddMatchup();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void buttonPrint2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Pairing";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "abc";
            printer.PrintDataGridView(dataGridViewPair);

        }
    }
}

