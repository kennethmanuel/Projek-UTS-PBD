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
        /// Create list that contains Prize object from selected database with all criteria selected.
        /// </summary>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Prize> BatchSearch(string criteriaValue)
        {
            string sql = "SELECT p.id, p.placename, p.prizeamount, p.prizepercentage,t.id, t.name, t.entryfee FROM prizes p INNER JOIN tournaments t ON p.tournaments_id = t.id WHERE p.id LIKE '%" + criteriaValue + "%' OR p.placename LIKE '%" + criteriaValue + "%' p.prizeamount LIKE '%" + criteriaValue + "%' OR p.prizepercentage LIKE '%" + criteriaValue + "%' OR t.name LIKE '%" + criteriaValue + "%'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Prize> prizeList = new List<Prize>();

            while (value.Read() == true)
            {
                Tournaments tournaments = new Tournaments(int.Parse(value.GetValue(4).ToString()), value.GetValue(5).ToString(), decimal.Parse(value.GetValue(6).ToString()));

                Prize p = new Prize(
                    int.Parse(value.GetValue(0).ToString()),
                    value.GetValue(1).ToString(),
                    decimal.Parse(value.GetValue(2).ToString()),
                    double.Parse(value.GetValue(3).ToString()),
                    tournaments);

                prizeList.Add(p);
            }
            return prizeList;
        }
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
                sql = "select p.id, p.placeName, p.prizeAmount, p.prizePercentage, p.tournaments_id, t.name, t.entryfee From prizes p inner join tournaments t on p.tournaments_id = t.id where p.tournaments_id in (select tt.id from tournaments tt where tournaments_id=" + tournamentsId + ")";
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
            string sql = "select max(Id) from Prizes";
            string code = "";
            MySqlDataReader result = Connection.ExecuteQuery(sql);

            if (result.Read() == true)
            {
                int newCode = int.Parse(result.GetValue(0).ToString()) + 1;
                code = newCode.ToString();
            }
            else
            {
                code = "1";
            }
            return code;
        }
        public static void AddData(Prize p)
        {
            string sql = "insert into Prizes(Id, PlaceName, PrizeAmount, PrizePercentage, Tournaments_Id) values ('" + p.Id + "','" + p.PlaceName.Replace("'", "\\'") + "','" + p.PrizeAmount + "','" + p.PrizePercentage + "','" + p.Tournament.Id + "')";
            Connection.ExecuteDML(sql);
        }
        public static string DeletePrize(Prize p)
        {
            string sql = "Delete from prizes where Id='" + p.Id + "'";
            try
            {
                Connection.ExecuteDML(sql);
                return "1";
            }
            catch (MySqlException ex)
            {
                return ex.Message + ". Sql Command: " + sql;
            }
        }
        public static Prize SelectPrize(int prizeId)
        {
            string sql = "select p.id, p.placeName, p.prizeAmount, p.prizePercentage, p.tournaments_id, t.name, t.entryfee FROM prizes p INNER JOIN tournaments t ON p.Tournaments_Id = t.Id  WHERE p.id=" + prizeId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            Tournaments tournaments = new Tournaments(int.Parse(value.GetValue(4).ToString()), value.GetValue(5).ToString(), decimal.Parse(value.GetValue(6).ToString()));
            
            Prize prize = new Prize(int.Parse(value.GetValue(0).ToString()), value.GetValue(1).ToString(), decimal.Parse(value.GetValue(2).ToString()), double.Parse(value.GetValue(3).ToString()), tournaments);
            
            
            return prize;
        }
        public static void EditPrize(Prize p)
        {
            string sql = "UPDATE prizes SET placename='" + p.PlaceName.Replace("'", "\\'") + "', prizeamount=" + p.PrizeAmount + ", prizepercentage=" + p.PrizePercentage +  ", tournaments_id=" + p.Tournament.Id + " WHERE id=" + p.Id ;

            Connection.ExecuteDML(sql);
        }
        #endregion
    }
}
