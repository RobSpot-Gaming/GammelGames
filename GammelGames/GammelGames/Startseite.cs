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
    public partial class Startseite : Form
    {
        Steuerung dieSteuerung;
        List<user> freundesliste;   // unbenutzt
        List<Spiel> bibliothek;

        public Startseite(Steuerung pSteuerung, String IdentetyName)
        {
            dieSteuerung = pSteuerung;
            freundesliste = new List<user>();
            bibliothek = new List<Spiel>();

            InitializeComponent();

            lbl_User.Text = "Angemeldet als: " + IdentetyName;
            bibliothek.AddRange(dieSteuerung.ladeBibliothek());
        }

        // anfang Freunde
        private void Freundeliste_Load(object sender, EventArgs e)  // laed die Freundesliste, wenn der Reiter geoeffnet wird
        {
            lbx_freunde.Items.Clear();
            lbx_freunde.Items.AddRange(dieSteuerung.ladeFreunde());
        }

        private void Freundeliste_MouseClick(object sender, MouseEventArgs e)   // zeigt wieder die Freundesliste, wenn auf die Flaeche geklickt wird
        {
            lbx_freunde.Items.Clear();
            lbx_freunde.Items.AddRange(dieSteuerung.ladeFreunde());
        }

        private void btn_suche_Click(object sender, EventArgs e)    // sucht nach Usern in der Datenbank
        {
            lbx_freunde.Items.Clear();
            string[] test = dieSteuerung.freundesuche(txt_suche.Text);  // string umbenennen
            lbx_freunde.Items.AddRange(test);
        }

        private void btn_hinzufuegen_Click(object sender, EventArgs e)  // fuegt Usern in die eigene Freundeliste ein
        {
            dieSteuerung.freundhinzufuegen(lbx_freunde.SelectedItem.ToString());
            btn_hinzufuegen.Enabled = false;
        }

        private void lbx_freunde_SelectedIndexChanged(object sender, EventArgs e)   // ausgewaehlter User wurde Gewechselt
        {
            btn_hinzufuegen.Enabled = true;
        }

        // anfang Bibliothek
        private void tb_Bibliothek_Enter(object sender, EventArgs e)    // beim betreten des Bibliotheks Reiters wird die Bibliothek geladen
        {
            bibliothek.Clear();
            bibliothek.AddRange(dieSteuerung.ladeBibliothek());

            lbx_Spiele.Items.Clear();
            foreach(Spiel dasSpiel in bibliothek)
            {
                lbx_Spiele.Items.Add(dasSpiel.Titel);
            }
        }
        
        private void lbx_Spiele_SelectedIndexChanged(object sender, EventArgs e)    // wenn ein Spiel ausgewaehlt wird, werden Titel und Beschreibung geladen
        {
            // aktualisieren der Anzeige

            Int32 index = lbx_Spiele.SelectedIndex;

            lbl_Titel.Text = bibliothek[index].Titel;
            lbl_Beschreibung.Text = bibliothek[index].Beschreibung;
        }

        // anfang shop
        private void btn_SpielSuche_Click(object sender, EventArgs e)   // suche von Spielen in der Datenbank
        {
            bibliothek.Clear();
            bibliothek.AddRange(dieSteuerung.sucheSpiel(txt_sucheSpiel.Text));

            lbx_ShopSpiele.Items.Clear();
            foreach (Spiel dasSpiel in bibliothek)
            {
                lbx_ShopSpiele.Items.Add(dasSpiel.Titel);
            }
        }

        private void lbx_ShopSpiele_SelectedIndexChanged(object sender, EventArgs e)    // Spiel wird in der Liste ausgewaehlt, Titel und Beschreiung angezeigt
        {
            Int32 index = lbx_ShopSpiele.SelectedIndex;

            btn_SpielHinzufuegen.Enabled = true;

            lbl_ShopTitel.Text = bibliothek[index].Titel;
            lbl_ShopBeschreibung.Text = bibliothek[index].Beschreibung;
        }

        private void btn_SpielHinzufuegen_Click(object sender, EventArgs e) // Spiel wird der eigenen Bibliothek hinzugefuegt
        {
            btn_SpielHinzufuegen.Enabled = false;
            dieSteuerung.spielHinzufuegen(bibliothek[lbx_ShopSpiele.SelectedIndex].SpielID);
        }
    }
}

