using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TournamentClassLibrary
{
    public class Connection
    {
        private MySqlConnection dbConnection;

        #region Constructor
        public Connection()
        {
            dbConnection = new MySqlConnection();

            dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["connectionName"].ConnectionString;
        }
        public Connection(string server, string database, string username, string password)
        {
            string strConnectionString;
            if (password != "")
            {
                strConnectionString = "Server=" + server + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";charset=utf8";
            }
            else
            {
                strConnectionString = "Server=" + server + ";Database=" + database + ";Uid=" + username + ";charset=utf8";
            }

            this.dbConnection = new MySqlConnection();
            this.dbConnection.ConnectionString = strConnectionString;

            Connect();

            UpdateAppConfig(strConnectionString);
        }

        #endregion

        #region Property
        public MySqlConnection DbConnection { get => dbConnection; private set => dbConnection = value; }
        #endregion

        #region Method
        /// <summary>
        /// Connect to DBMS
        /// </summary>
        public void Connect()
        {
            //Close connection if connection is currently opened
            if(dbConnection.State == System.Data.ConnectionState.Open)
            {
                dbConnection.Close();
            }
            dbConnection.Open();
        }

        public void UpdateAppConfig(string con)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["connectionName"].ConnectionString = con;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static void ExecuteDML(string sql)
        {
            Connection connection = new Connection();

            MySqlCommand command = new MySqlCommand(sql, connection.dbConnection);

            command.ExecuteNonQuery();
        }

        public static MySqlDataReader ExecuteQuery(string sql)
        {
            Connection connection = new Connection();

            MySqlCommand command = new MySqlCommand(sql, connection.dbConnection);

            MySqlDataReader hasil = command.ExecuteReader();

            return hasil;
        }

        #endregion

    }
}
