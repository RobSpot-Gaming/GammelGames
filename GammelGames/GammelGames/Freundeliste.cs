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
    public partial class Freundeliste : Form
    {
        Steuerung dieSteuerung;
        List<user> freundesliste;

        public Freundeliste(Steuerung pSteuerung)
        {
            dieSteuerung = pSteuerung;
            freundesliste = new List<user>();
            InitializeComponent();
        }

        private void btn_suche_Click(object sender, EventArgs e)
        {
            lbx_freunde.Items.Clear();
            string[] test = dieSteuerung.freundesuche(txt_suche.Text);
            lbx_freunde.Items.AddRange(test);
        }

        private void btn_hinzufuegen_Click(object sender, EventArgs e)
        {
            dieSteuerung.freundhinzufuegen(lbx_freunde.SelectedItem.ToString());
        }

        private void lbx_freunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_hinzufuegen.Enabled = true;
        }

        private void Freundeliste_Load(object sender, EventArgs e)
        {
            lbx_freunde.Items.Clear();
            lbx_freunde.Items.AddRange(dieSteuerung.ladeFreunde());
        }

        private void Freundeliste_MouseClick(object sender, MouseEventArgs e)
        {
            lbx_freunde.Items.Clear();
            lbx_freunde.Items.AddRange(dieSteuerung.ladeFreunde());
        }
    }
}
