﻿using MySql.Data.MySqlClient;
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
        private double totalScore;

        #region Constructor
        public Teams(int id, string name, double totalScore)
        {
            this.Id = id;
            this.Name = name;
            this.TotalScore = totalScore;
        }
        #endregion

        #region Property
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double TotalScore { get => totalScore; set => totalScore = value; }
        #endregion

        #region Methods
        /// <summary>
        /// Create a list of Teams object from a selected database with a specified criteria.
        /// </summary>
        /// <param name="criteria"></param>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
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
                int teamId = int.Parse(value.GetValue(0).ToString());
                string teamName = value.GetValue(1).ToString();
                double totalScore = double.Parse(value.GetValue(2).ToString());

                Teams t = new Teams(teamId, teamName, totalScore);

                teamList.Add(t);
            }
            return teamList;
        }

        /// <summary>
        /// Create list of a Teams object from a selected database with all criteria selected.
        /// </summary>
        /// <param name="criteriaValue"></param>
        /// <returns></returns>
        public static List<Teams> BatchSearch(string criteriaValue)
        {
            string sql = "SELECT * FROM teams WHERE id LIKE '%" + criteriaValue + "%' OR name LIKE '%" + criteriaValue + "%'";

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            List<Teams> teamList = new List<Teams>();

            while (value.Read() == true)
            {
                int teamId = int.Parse(value.GetValue(0).ToString());
                string teamName = value.GetValue(1).ToString();
                double totalScore = double.Parse(value.GetValue(2).ToString());

                Teams t = new Teams(teamId, teamName, totalScore);

                teamList.Add(t);
            }

            return teamList;
        }

        /// <summary>
        /// Add new team to database
        /// </summary>
        /// <param name="p"></param>
        public static void AddTeams(Teams t, Tournaments selectedTournament)
        {
            string sql = "INSERT INTO teams(Id, Name, totalscore) VALUES ('" + t.Id + "','" + t.Name.Replace("'", "\\'") + "','" + t.totalScore + "');  INSERT INTO tournamententry VALUES ('"+ selectedTournament.Id + "', '" + t.Id +  "');";

            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// EditTeam from database
        /// </summary>
        /// <param name="t"></param>
        public static void EditTeams(Teams t)
        {
            string sql = "update teams set Name='" + t.Name.Replace("'", "\\'") + "' where Id='" + t.Id + "'";
            Connection.ExecuteDML(sql);
        }

        /// <summary>
        /// Delete Team from database
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public static string DeleteTeams(Teams team)
        {
            string sql = "DELETE FROM players WHERE team_id="+ team
                .Id+"; DELETE FROM tournamententry  WHERE teams_id="+team.Id+"; DELETE FROM Teams WHERE Id = '" + team.Id + "';";
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

        /// <summary>
        /// Generate new Id
        /// </summary>
        /// <returns></returns>
        public static string GenerateCode()
        {
            string sql = "select max(Id) from Teams";
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

        /// <summary>
        /// Select a team based on its id
        /// </summary>
        /// <param name="teamId"></param>
        /// <returns></returns>
        public static Teams SelectTeam(int teamId)
        {
            string sql = "SELECT * FROM teams t WHERE t.id=" + teamId;

            MySqlDataReader value = Connection.ExecuteQuery(sql);

            value.Read();

            Teams t = new Teams(int.Parse(value.GetValue(0).ToString()), value.GetValue(1).ToString(), double.Parse(value.GetValue(2).ToString()));

            return t;
        }
        
        #endregion
    }
}
