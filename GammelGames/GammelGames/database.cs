using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GammelGames
{
    class database
    {

        private string datenbankName;
        private MySqlConnection conn;
        public database(/*string ConnectionString, string DatenbankName*/)
        {
            //create a MySQL connection with a query string 
            /*conn = new MySqlConnection(ConnectionString); //  "Data Source = localhost; Database = stasibot; Uid = levelbot; Pwd = MhsUgUeuQuqadAlh;" 
            datenbankName = DatenbankName;*/
            datenbankName = "GammelGames";
            conn = new MySqlConnection("Data Source=localhost;User Id = root; SslMode=none;");//Database=StasiBot;Data Source=localhost;User Id = root
            createDatabase();
        }

        private void createDatabase()
        {
            Boolean vorhanden = false;
            string pCommand = "SHOW DATABASES;";
            foreach (string dbname in executeReader(pCommand))
            {
                if (dbname == datenbankName)
                {
                    pCommand = "CREATE DATABASE " + datenbankName + ";";
                    executeQuarry(pCommand);

                    conn.Open();
                    conn.ChangeDatabase(datenbankName);
                    conn.Close();
                    pCommand = "CREATE TABLE `gammelgames`.`User` ( `UserID` INT NOT NULL AUTO_INCREMENT, `UserName` VARCHAR(255) NOT NULL, `UserPassword` VARCHAR(255) NOT NULL, PRIMARY KEY(`UserID`)) ENGINE = InnoDB;";

                    executeQuarry(pCommand);
                    vorhanden = true;
                }
            }
            if(vorhanden == false)
            {
                conn.Open();
                conn.ChangeDatabase(datenbankName);
                conn.Close();
            }
        }

        public Boolean login(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "' AND UserPassword = '" + pPassword + "';";
            return executeReader(pCommand).Length != 0;
        }

        public Boolean registrieren(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "';";
            if (executeReader(pCommand).Length != 0)
            {
                return false;
            }
            else
            {
                pCommand = "INSERT INTO User (UserID, UserName, UserPassword) VALUES ( NULL, '" + pUsername + "', '" + pPassword + "');";
                executeQuarry(pCommand);
                return true;
            }

        }

        /*
        private Int32 select(Int32 ClientID)
        {
            string pCommand = "SELECT ClientTime FROM " + datenbankName + " WHERE ClientID = " + ClientID;
            return executeReader(pCommand);
        }//                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           robert stinkt                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       hart                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    nach                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        kartoffelsnack                                


        private Int32 insert(Int32 ClientID, Int32 Zeit)
        {
            string pCommand = "INSERT " + datenbankName + " (ClientID, ClientTime) VALUES (" + ClientID + ", " + Zeit + ")";
            return executeQuarry(pCommand);
        }


        private Int32 insert(Int32 ClientID, Int32 Zeit, String ClientName)
        {
            string pCommand = "INSERT " + datenbankName + " (ClientID, ClientTime, ClientName) VALUES (" + ClientID + ", " + Zeit + ", '" + ClientName + "')";
            //Console.WriteLine(pCommand); 
            return executeQuarry(pCommand);
        }


        private Int32 update(Int32 ClientID, Int32 Zeit)
        {
            string pCommand = "UPDATE " + datenbankName + " SET ClientTime = " + Zeit + " WHERE ClientID = " + ClientID;
            return executeQuarry(pCommand);
        }
        */

        private Int32 executeQuarry(string sCommand)
        {
            Int32 anzahlZeilen = -1;
            try
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand(sCommand, conn);
                anzahlZeilen = command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("keine Verbindung möglich!");
            }


            return anzahlZeilen;
        }


        private String[] executeReader(string sCommand)
        {

            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("keine Verbindung möglich!");
            }





            MySqlCommand command = new MySqlCommand(sCommand, conn);

            List<String> data = new List<string>();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    data.Add(Convert.ToString(reader[0]));
                }
                conn.Close();
                return data.ToArray();
            }
        }
    }
}
