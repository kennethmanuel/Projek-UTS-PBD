using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Prize
    {
        /// <summary>
        /// Id is also place number (Id 1 is first place, id 2 is second place and so on)
        /// </summary>
        private int id;
        private string placeName;
        private decimal prizeAmount;
        private double prizePercentage;
        private Tournaments tournament;

        #region Constructor
        public Prize(int id, string placeName, decimal prizeAmount, double prizePercentage, Tournaments tournament)
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
        public decimal PrizeAmount { get => prizeAmount; set => prizeAmount = value; }
        public double PrizePercentage { get => prizePercentage; set => prizePercentage = value; }
        public Tournaments Tournament { get => tournament; set => tournament = value; }
        #endregion

        #region Method
        
        /// <summary>
        /// read data prize
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Prize> ReadData(Tournaments selectedTournaments, string criteria)
        {
            int tournamentsId = selectedTournaments.Id;
            string sql = "";
            if (criteria == "")
            {
                sql = "SELECT p.Id, p.PlaceName, p.PrizeAmount, p.PrizePercentage, p.Tournaments_Id, t.Name, t.EntryFee " +
                        "FROM prizes p " +
                        "INNER JOIN tournaments t ON p.Tournaments_Id = t.Id " +
                        "WHERE p.Tournaments_Id =" + tournamentsId + "";
            }
            else
            {
                sql = "select p.id, p.placeName, p.prizeAmount, p.prizePercentage, p.tournaments_id, t.name, t.entryfee FROM prizes p INNER JOIN tournaments t ON p.tournaments_id = t.id where p.tournaments_id in (select tt.id from tournaments tt where tournaments_id=" + tournamentsId + ") AND ( p.id LIKE '%" + criteria + "%' OR p.placeName LIKE '%" + criteria + "%' OR p.prizeAmount LIKE '%" + criteria + "%' OR p.prizePercentage LIKE '%" + criteria + "%'   )";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Prize> listPrize = new List<Prize>();

            while (value.Read() == true)
            {
                Tournaments tournaments = new Tournaments(int.Parse(value.GetValue(4).ToString()), value.GetValue(5).ToString(), decimal.Parse(value.GetValue(6).ToString()));
                Prize prize = new Prize(int.Parse(value.GetValue(0).ToString()), value.GetValue(1).ToString(), decimal.Parse(value.GetValue(2).ToString()), double.Parse(value.GetValue(3).ToString()), tournaments);
                listPrize.Add(prize);
            }
            return listPrize;
        }

        /// <summary>
        /// Generate new ID
        /// </summary>
        /// <returns></returns>
        public static string GenerateCode()
        {
            string sql = "SELECT MAX(Id) " +
                         "FROM Prizes";

            string newId;

            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read())
            {
                int newIdInt = int.Parse(result.GetValue(0).ToString()) + 1;
                newId = newIdInt.ToString();
            }
            else
            {
                newId = "1";
            }
            return newId;
        }

        public static void AddData(Prize p)
        {
            string sql = "INSERT INTO Prizes(Id, PlaceName, PrizeAmount, PrizePercentage, Tournaments_Id) " +
                         "VALUES ('" + p.Id + "','" + p.PlaceName.Replace("'", "\\'") + "','" + p.PrizeAmount + "','" + p.PrizePercentage + "','" + p.Tournament.Id + "')";

            Connection.ExecuteDML(sql);
        }

        public static bool DeletePrize(Prize p, out string exceptionMessage)
        {
            string sql = "DELELTE FROM prizes " +
                         "WHERE Id='" + p.Id + "'";

            exceptionMessage = "";

            try
            {
                Connection.ExecuteDML(sql);
                return true;
            }
            catch (MySqlException ex)
            {
                exceptionMessage = ex.Message;
                return false;
            }
        }
        public static Prize SelectPrize(int prizeId)
        {
            string sql = "SELECT p.id, p.placeName, p.prizeAmount, p.prizePercentage, p.tournaments_id, t.name, t.entryfee " + 
                    " FROM prizes p " + 
                    " INNER JOIN tournaments t ON p.Tournaments_Id = t.Id  " + 
                    " WHERE p.id=" + prizeId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            Tournaments tournaments = new Tournaments(int.Parse(value.GetValue(4).ToString()), value.GetValue(5).ToString(), decimal.Parse(value.GetValue(6).ToString()));
            
            Prize prize = new Prize(int.Parse(value.GetValue(0).ToString()), value.GetValue(1).ToString(), decimal.Parse(value.GetValue(2).ToString()), double.Parse(value.GetValue(3).ToString()), tournaments);
            
            
            return prize;
        }

        public static void EditPrize(Prize p)
        {
            string sql = "UPDATE prizes " +
                         "SET placename='" + p.PlaceName.Replace("'", "\\'") + "', prizeamount=" + p.PrizeAmount + ", prizepercentage=" + p.PrizePercentage +  ", tournaments_id=" + p.Tournament.Id + " " +
                         "WHERE id=" + p.Id ;

            Connection.ExecuteDML(sql);
        }
        #endregion
    }
}
