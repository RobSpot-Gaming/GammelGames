using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammelGames
{
    public class Spiel
    {
        private Int32 aSpielID;
        private String aTitel;
        private String aBeschreibung;

        public Spiel(Int32 ID,  String Titel, String Beschreibung)
        {
            aSpielID = ID;
            aTitel = Titel;
            aBeschreibung = Beschreibung;
        }

        public string Titel
        {
            get
            {
                return aTitel;
            }

            set
            {
                aTitel = value;
            }
        }

        public string Beschreibung
        {
            get
            {
                return aBeschreibung;
            }

            set
            {
                aBeschreibung = value;
            }
        }

        public int SpielID
        {
            get
            {
                return aSpielID;
            }

            set
            {
                aSpielID = value;
            }
        }
    }
}
