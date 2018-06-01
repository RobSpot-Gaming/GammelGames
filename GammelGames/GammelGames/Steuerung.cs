using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GammelGames
{
    public class Steuerung
    {
        private Form dieOberflaeche;
        private DatenbankVerwaltung dieDatenbank;
        private user identety;
        

        public Steuerung()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dieOberflaeche = new Anmeldung(this);
            dieOberflaeche.Show();

            dieDatenbank = new DatenbankVerwaltung();
        }

        public Boolean anmelden(string pNickname, string pPassword)
        {
            Int32 id = dieDatenbank.login(pNickname, pPassword);
            if (id != 0)
            {
                identety = new user(pNickname, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean registrieren(string pNickname, string pPassword)
        {
            // eigentlich noch hashen
            if(dieDatenbank.registrieren(pNickname, pPassword))
            {
                Int32 id = dieDatenbank.giveUserID(pNickname);
                identety = new user(pNickname, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void angemeldet()
        {
            dieOberflaeche = new Startseite(this, identety.AName);
            dieOberflaeche.Show();
        }


        public string[] freundesuche(string pSuche) // sucht nach User
        {
            return dieDatenbank.freundesuche(pSuche);
        }

        public void freundhinzufuegen(string pFreund)   // gibt Freunde zurueck
        {
            dieDatenbank.feundhinzufuegen(identety.AName, pFreund);
        }

        public string[] ladeFreunde()
        {
            return dieDatenbank.loadfriends(identety.AID);
        }

        public Spiel[] sucheSpiel(String SpielName)
        {
            return dieDatenbank.sucheSpiel(SpielName);
        }

        public Spiel[] ladeBibliothek()
        {
            return dieDatenbank.ladeBibliothek(identety.AID);
        }

        public void spielHinzufuegen(Int32 SpielID)
        {
            dieDatenbank.hinzufuegenSpiel(identety.AID, SpielID);
        }
    }
}
