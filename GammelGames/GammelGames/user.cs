using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammelGames
{
    class user
    {
        string ID;
        string Name;
        string NickName;
        string Email;
        Enumerationen.EnmSpielerZustand Status;


        /// <summary>
        /// Construktor der User-Klasse. Erstellt die Klasse und füllt die Felder aus.
        /// </summary>
        /// <param name="pID">Eindeutige-ID des Users in der Datenbank des Servers</param>
        /// <param name="pName">Anzeigename des Users</param>
        /// <param name="pNickName">Anmelde-Nickname des Users</param>
        /// <param name="pEmail">E-Mail Adresse des Users</param>
        public user(string pID, string pName, string pNickName, string pEmail)
        {
            ID = pID;
            Name = pName;
            NickName = pNickName;
            Email = pEmail;
            Status = Enumerationen.EnmSpielerZustand.eOnline;

        }
    }
}
