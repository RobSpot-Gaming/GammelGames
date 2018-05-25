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
        private database dieDatabase;

        private string name;
        private string passwort;

        public Steuerung()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dieOberflaeche = new Anmeldung(this);
            dieOberflaeche.Show();

            dieDatabase = new database();
        }

        public Boolean anmelden(string pNickname, string pPassword)
        {
            if(dieDatabase.login(pNickname, pPassword))
            {
                name = pNickname;
                passwort = pPassword;
            }
            return true;
        }

        public void registrieren(string pNickname, string pPassword)
        {
            
        }

        public void angemeldet()
        {
            dieOberflaeche = new Form1();
            dieOberflaeche.Show();
        }
    }
}
