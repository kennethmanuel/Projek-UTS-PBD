using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentClassLibrary
{
    public class Teams
    {
        private int id;
        private string name;

        #region Constructor
        public Teams(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        #endregion

        #region Methods
        public static List<Teams> ReadData(string criteria, string criteriaValue)
        {
            string sql = "";

            if(criteria == "")
            {
                sql = "SELECT * FROM teams";
            }
            else
            {
                sql = "SELECT * FROM teams WHERE " + criteria + " LIKE '%" + criteriaValue + "%'";
            }

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while(value.Read() == true)
            {
                Teams t = new Teams(int.Parse(value.GetValue(0).ToString()), value.GetValue(1).ToString());

                teamList.Add(t);
            }
            return teamList;
        }
        #endregion


    }
}
