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
            TestPairing2();
        }
        /// <summary>
        /// Format DataGrid
        /// </summary>
        private void FormatDataGrid()
        {
            dataGridViewPair.Columns.Clear();
            dataGridViewPair.Columns.Add("Team1", "Team 1");
            dataGridViewPair.Columns.Add("ScoreTeam1", "Score Team 1");
            dataGridViewPair.Columns.Add("", "");
            dataGridViewPair.Columns.Add("ScoreTeam2", "Score Team 2");
            dataGridViewPair.Columns.Add("Team2", "Team 2");
            dataGridViewPair.Columns.Add("Round", "Round");            
        }
        
       /// <summary>
       /// Display Data Value Datagrid from database
       /// </summary>
        public void TestPairing2()
        {
            string output = "";

            foreach (Pairing pair in listPair)
            {                
                dataGridViewPair.Rows.Add(pair.Team1.Name,"" , "vs","" , pair.Team2.Name, pair.Round);
            }        

        }
    }
}
