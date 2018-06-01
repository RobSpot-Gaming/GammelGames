using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammelGames
{
    class user
    {
        Int32 aID;
        string aName;
        string aNickName;
        string aEmail;
        Enumerationen.EnmSpielerZustand aStatus;

        public string AName
        {
            get
            {
                return aName;
            }

            set
            {
                aName = value;
            }
        }

        public Int32 AID
        {
            get
            {
                return aID;
            }

            set
            {
                aID = value;
            }
        }


        /// <summary>
        /// Construktor der User-Klasse. Erstellt die Klasse und füllt die Felder aus.
        /// </summary>
        /// <param name="pID">Eindeutige-ID des Users in der Datenbank des Servers</param>
        /// <param name="pName">Anzeigename des Users</param>
        /// <param name="pNickName">Anmelde-Nickname des Users</param>
        /// <param name="pEmail">E-Mail Adresse des Users</param>
        /// 
        //public user(string pID, string pName, string pNickName, string pEmail)
        public user(string pName, Int32 pID)
        {
            aID = pID;
            aName = pName;
            //aNickName = pNickName;
            //Email = pEmail;
            aStatus = Enumerationen.EnmSpielerZustand.eOnline;

        }

        public user(string pName)
        {
            aName = pName;
        }
    }
}
