using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Server
{
    class database
    {

        private string datenbankName;
        private MySqlConnection conn;
        public database(string ConnectionString, string DatenbankName)
        {
            //create a MySQL connection with a query string 
            conn = new MySqlConnection(ConnectionString); //  "Data Source = localhost; Database = stasibot; Uid = levelbot; Pwd = MhsUgUeuQuqadAlh;" 
            datenbankName = DatenbankName;
        }
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


        private Int32 executeQuarry(string sCommand)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("!!!!!!Verbindung zur Datenbank nicht Möglich!!!!!!");
                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }


            MySqlCommand command = new MySqlCommand(sCommand, conn);
            Int32 anzahlZeilen = command.ExecuteNonQuery();
            conn.Close();
            return anzahlZeilen;
        }


        private Int32 executeReader(string sCommand)
        {
            Int32 Data = -1;


            try
            {
                conn.Open();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("!!!!!!Verbindung zur Datenbank nicht Möglich!!!!!!");
                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }





            MySqlCommand command = new MySqlCommand(sCommand, conn);


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Data = Convert.ToInt32(reader[0]);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                }
                conn.Close();
                return Data;
            }
        }
    }
}

