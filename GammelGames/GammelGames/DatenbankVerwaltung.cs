using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammelGames
{
    class DatenbankVerwaltung
    {
        database dieDatenbank;

        public DatenbankVerwaltung()
        {
            dieDatenbank = new database();
        }

        public Int32 giveUserID(string pName)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pName + "';";
            string[] ids = dieDatenbank.executeReader(pCommand);
            if (ids != null)
            {
                return Convert.ToInt32(ids[0]);
            }
            else
            {
                return 0;
            }
        }

        public Int32 login(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "' AND UserPassword = '" + pPassword + "';";
            string[] userID = dieDatenbank.executeReader(pCommand);
            if (userID.Length >= 1)
                return Convert.ToInt32(userID[0]);
            else
                return 0;
        }

        public string[] freundesuche(string psuche) // sucht nach Usern
        {
            string pCommand = "SELECT UserName FROM user WHERE UserName LIKE '%" + psuche + "%';";
            return dieDatenbank.executeReader(pCommand);
        }

        public void feundhinzufuegen(string pName, string pFreund)
        {
            Int32 pUserID = 0;
            Int32 pFreundID = 0;

            List<string> ids = new List<string>();

            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pName + "';";
            ids.AddRange(dieDatenbank.executeReader(pCommand));

            pCommand = "SELECT UserID FROM User WHERE UserName = '" + pFreund + "';";
            ids.AddRange(dieDatenbank.executeReader(pCommand));

            if (ids.Count == 2)
            {
                pUserID = Convert.ToInt32(ids[0]);
                pFreundID = Convert.ToInt32(ids[1]);

                pCommand = "INSERT INTO Freundesliste (ListeID, UserID, FreundID) VALUES (NULL, " + ids[0] + ", " + ids[1] + ");";
                dieDatenbank.executeQuarry(pCommand);
            }

        }

        public string[] loadfriends(Int32 pUserID)  // Gibt die freunde aus
        {
            string pCommand = "SELECT u.UserName FROM user u, freundesliste f WHERE f.UserID = '" + pUserID + "' AND u.UserID = f.FreundID;";
            return dieDatenbank.executeReader(pCommand);
        }



        public Boolean registrieren(string pUsername, string pPassword)
        {
            string pCommand = "SELECT UserID FROM User WHERE UserName = '" + pUsername + "';";
            if (dieDatenbank.executeReader(pCommand).Length != 0)
            {
                return false;   // falls es den nutzernamen gibt, kann kein neuer account erstellt werden
            }
            else
            {   // falls nicht gibt es einen neuen Eintrag
                pCommand = "INSERT INTO User (UserID, UserName, UserPassword) VALUES ( NULL, '" + pUsername + "', '" + pPassword + "');";
                dieDatenbank.executeQuarry(pCommand);
                return true;
            }

        }

        public Spiel[] ladeBibliothek(Int32 UserID)
        {
            String pCommand = "SELECT s.SpielID, s.SpielTitel, s.SpielBeschreibung FROM Spiel s, Bibliothek b WHERE b.UserID = " + UserID + " AND b.SpielID = s.SpielID; ";

            String[] data = dieDatenbank.executeReader(pCommand);

            Spiel[] bibliothek = new Spiel[data.Length / 3];

            Int16 a = 0;
            for (int i = 0; i < data.Length; i = i + 3)
            {
                bibliothek[a] = new Spiel(Convert.ToInt32(data[i]), data[i + 1], data[i + 2]);
                a++;
            }

            return bibliothek;
        }

        public Spiel[] sucheSpiel(String SpielName)
        {
            String pCommand = "SELECT SpielID, SpielTitel, SpielBeschreibung FROM Spiel WHERE SpielTitel LIKE '%" + SpielName + "%';";
            String[] data = dieDatenbank.executeReader(pCommand);

            Spiel[] spiele = new Spiel[data.Length / 3];

            Int16 a = 0;
            for (int i = 0; i < data.Length; i = i + 3)
            {
                spiele[a] = new Spiel(Convert.ToInt32(data[i]), data[i + 1], data[i + 2]);
                a++;
            }

            return spiele;
        }

        public void hinzufuegenSpiel(Int32 UserID, Int32 SpielID)
        {
            String pCommand = "INSERT INTO `bibliothek` (`BibID`, `UserID`, `SpielID`) VALUES(NULL, '" + UserID + "', '" + SpielID + "');";
            dieDatenbank.executeQuarry(pCommand);
        }
    }
}
