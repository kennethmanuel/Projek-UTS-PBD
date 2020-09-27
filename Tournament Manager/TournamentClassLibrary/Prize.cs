using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Prize
    {
        private int id; //id is also a place number
        private string placeName;
        private int prizeAmount;
        private double prizePercentage;
        private Tournaments tournament;

        #region Constructor
        public Prize(int id, string placeName, int prizeAmount, double prizePercentage, Tournaments tournament)
        {
            this.Id = id;
            this.PlaceName = placeName;
            this.PrizeAmount = prizeAmount;
            this.PrizePercentage = prizePercentage;
            this.Tournament = tournament;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string PlaceName { get => placeName; set => placeName = value; }
        public int PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
        public double PrizePercentage { get => prizePercentage; set => prizePercentage = value; }
        public Tournaments Tournament { get => tournament; set => tournament = value; }
        #endregion

        #region Method
        public static List<Prize> BatchSearch(string criteriaValue)
        {
            string sql = "SELECT p.id, p.placename, p.prizeamount, p.prizepercentage,t.id, t.name, t.entryfee FROM prizes p INNER JOIN tournaments t ON p.tournaments_id = t.id WHERE p.id LIKE '%" + criteriaValue + "%' OR p.placename LIKE '%" + criteriaValue + "%' p.prizeamount LIKE '%" + criteriaValue + "%' OR p.prizepercentage LIKE '%" + criteriaValue + "%' OR t.name LIKE '%" + criteriaValue + "%'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Prize> prizeList = new List<Prize>();

            while(value.Read() == true)
            {
                Tournaments tournaments = new Tournaments(int.Parse(value.GetValue(4).ToString()), value.GetValue(5).ToString(), decimal.Parse(value.GetValue(6).ToString()));

                Prize p = new Prize(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    int.Parse(value.GetValue(2).ToString()),
                    double.Parse(value.GetValue(3).ToString()),
                    tournaments);

                prizeList.Add(p);
            }
            return prizeList;
        }

        #endregion
    }
}
