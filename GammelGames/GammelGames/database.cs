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
            datenbankName = "gammelgames";
            conn = new MySqlConnection("Data Source=localhost;User Id = root; SslMode=none;"); //Verbindungsstring zur lokalen MySQL Datenbank, ohne ssl Verschlüsselung
            createDatabase();
        }

        private void createDatabase()
        {
            Boolean vorhanden = false;
            string pCommand = "SHOW DATABASES;";    // gib die namen der Databases zurück
            foreach (string dbname in executeReader(pCommand))  // es wird geschaut, ob es eine Datenbank mit dem Namen "gammelgames" gibt
            {
                if (dbname == datenbankName)
                {
                    vorhanden = true;
                }
            }

            if(vorhanden == false)  // falls nicht, wird eine Datenbank erstellt 
            {
                pCommand = "CREATE DATABASE " + datenbankName + ";";
                executeQuarry(pCommand);

                conn.ChangeDatabase(datenbankName); // und in sie gewechselt
                pCommand = "CREATE TABLE `" + datenbankName + "`.`User` ( `UserID` INT NOT NULL AUTO_INCREMENT, `UserName` VARCHAR(255) NOT NULL, `UserPassword` VARCHAR(255) NOT NULL, PRIMARY KEY(`UserID`)) ENGINE = InnoDB;";

                executeQuarry(pCommand);
            }
            else
            {                               // ansonsten nur gewechselt
                conn.Open();
                conn.ChangeDatabase(datenbankName);
                conn.Close();
            }
        }

        public Boolean login(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "' AND UserPassword = '" + pPassword + "';";
            return executeReader(pCommand).Length != 0; // falls das Array keine Einträge hat, gibt es den benutzer nicht
        }

        public Boolean registrieren(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "';";
            if (executeReader(pCommand).Length != 0)
            {
                return false;   // falls es den nutzernamen gibt, kann kein neuer account erstellt werden
            }
            else
            {   // falls nicht gibt es einen neuen Eintrag
                pCommand = "INSERT INTO User (UserID, UserName, UserPassword) VALUES ( NULL, '" + pUsername + "', '" + pPassword + "');";
                executeQuarry(pCommand);
                return true;
            }

        }

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
            catch
            {
                MessageBox.Show("keine Verbindung möglich!");
                return null;
            }





            
        }
    }
}
