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
        public database()
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

                pCommand = "CREATE TABLE `" + datenbankName + "`.`User` ( `UserID` INT NOT NULL AUTO_INCREMENT, `UserName` VARCHAR(255) NOT NULL, `UserPassword` VARCHAR(255) NOT NULL, PRIMARY KEY(`UserID`)) ENGINE = InnoDB;";
                executeQuarry(pCommand);

                pCommand = "CREATE TABLE `" + datenbankName + "`.`Freundesliste` ( `ListID` INT NOT NULL AUTO_INCREMENT, `UserID` INT(11) NOT NULL, `FreundID` INT(11) NOT NULL, PRIMARY KEY(`ListID`)) ENGINE = InnoDB;";
                executeQuarry(pCommand);

                pCommand = "CREATE TABLE `" + datenbankName + "`.`bibliothek` ( `BibID` INT(11) NOT NULL AUTO_INCREMENT , `UserID` INT(11) NOT NULL , `SpielID` INT(11) NOT NULL , PRIMARY KEY (`BibID`)) ENGINE = InnoDB;";
                executeQuarry(pCommand);

                pCommand = "CREATE TABLE `" + datenbankName + "`.`spiel` ( `SpielID` INT NOT NULL AUTO_INCREMENT, `SpielTitel` VARCHAR(255) NOT NULL, `SpielBeschreibung` TEXT NULL, PRIMARY KEY(`SpielID`)) ENGINE = InnoDB;";
                executeQuarry(pCommand);
            }                             // und in sie gewechselt

            conn.Open();
            conn.ChangeDatabase(datenbankName);
            conn.Close();
            
        }

        

        public Int32 executeQuarry(string sCommand) // Fuehrt ein SQL Befehl aus
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

        public String[] executeReader(string sCommand)  // Fuehrt ein SQL Befehl mit reader aus, die Rueckgabe wird uebergeben (SELECT befehl)
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
                        for(int i = 0; i < reader.FieldCount; i++)
                            data.Add(Convert.ToString(reader[i]));
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
