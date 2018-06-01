using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GammelGames
{
    public partial class Anmeldung : Form
    {
        private Steuerung dieSteuerung;

        public Anmeldung(Steuerung pSteuerung)
        {
            dieSteuerung = pSteuerung;
            
            InitializeComponent();
        }

        private void btn_anmelden_Click(object sender, EventArgs e)
        {
            if(dieSteuerung.anmelden(txt_nickname.Text, txt_passwort.Text))
            {
                // anmeldung geklappt
                dieSteuerung.angemeldet();
                this.Dispose();
            }
            else
            {
                // anmeldung fehlerhaft
                fehler("Name oder Passwort Falsch!");
            }
        }

        private void btn_registrieren_Click(object sender, EventArgs e)
        {
            if(dieSteuerung.registrieren(txt_nickname.Text, txt_passwort.Text))
            {
                dieSteuerung.angemeldet();
                this.Dispose();
            }
            else
            {
                fehler("Nutzername schon vergeben.");
            }
        }

        private void fehler(string pFehler)
        {
            lbl_fehler.Text = pFehler;
            lbl_fehler.Visible = true;
        }
    }
}
