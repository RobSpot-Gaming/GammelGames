using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace GammelGames
{
    class network
    {
        int port = 8081;
        IPAddress ipAd = IPAddress.Parse("10.21.11.4");
        TcpListener Listener;

        /// <summary>
        /// Diese Methode wird dazu verwendet, um eine Verbinung mit dem Server herzustellen.
        /// </summary> 
        /// <returns>Gibt an, ob der Verbindungsversuch erfolgreich war.</returns>
        public bool connect()
        {
            Listener = new TcpListener(ipAd, port);
            try
            {
                Listener.Start();
                Socket mySocket = Listener.AcceptSocket();
                byte[] b = new byte[1000];
                int k = mySocket.Receive(b);
                string answer = "";
                for (int i = 0; i < k; i++)
                {
                    answer = answer + Convert.ToChar(b[i]);
                }

                if (answer == "Gammliger-Server")
                {
                    return true;
                }

            }
            
        
        
            catch
            {
                return false;
            }
            return true;
        }

    }
}
