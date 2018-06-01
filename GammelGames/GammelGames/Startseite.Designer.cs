namespace GammelGames
{
    partial class Startseite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Freunde = new System.Windows.Forms.TabPage();
            this.btn_hinzufuegen = new System.Windows.Forms.Button();
            this.btn_suche = new System.Windows.Forms.Button();
            this.txt_suche = new System.Windows.Forms.TextBox();
            this.lbx_freunde = new System.Windows.Forms.ListBox();
            this.tb_Bibliothek = new System.Windows.Forms.TabPage();
            this.btn_SpielEntfernen = new System.Windows.Forms.Button();
            this.btn_SpielStarten = new System.Windows.Forms.Button();
            this.lbl_Beschreibung = new System.Windows.Forms.Label();
            this.lbl_Titel = new System.Windows.Forms.Label();
            this.lbx_Spiele = new System.Windows.Forms.ListBox();
            this.tb_Shop = new System.Windows.Forms.TabPage();
            this.lbl_ShopBeschreibung = new System.Windows.Forms.Label();
            this.lbl_ShopTitel = new System.Windows.Forms.Label();
            this.btn_SpielHinzufuegen = new System.Windows.Forms.Button();
            this.btn_SpielSuche = new System.Windows.Forms.Button();
            this.txt_sucheSpiel = new System.Windows.Forms.TextBox();
            this.lbx_ShopSpiele = new System.Windows.Forms.ListBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb_Freunde.SuspendLayout();
            this.tb_Bibliothek.SuspendLayout();
            this.tb_Shop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_Freunde);
            this.tabControl1.Controls.Add(this.tb_Bibliothek);
            this.tabControl1.Controls.Add(this.tb_Shop);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tb_Freunde
            // 
            this.tb_Freunde.Controls.Add(this.btn_hinzufuegen);
            this.tb_Freunde.Controls.Add(this.btn_suche);
            this.tb_Freunde.Controls.Add(this.txt_suche);
            this.tb_Freunde.Controls.Add(this.lbx_freunde);
            this.tb_Freunde.Location = new System.Drawing.Point(4, 22);
            this.tb_Freunde.Name = "tb_Freunde";
            this.tb_Freunde.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Freunde.Size = new System.Drawing.Size(515, 275);
            this.tb_Freunde.TabIndex = 0;
            this.tb_Freunde.Text = "Freunde";
            this.tb_Freunde.UseVisualStyleBackColor = true;
            this.tb_Freunde.Enter += new System.EventHandler(this.Freundeliste_Load);
            this.tb_Freunde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Freundeliste_MouseClick);
            // 
            // btn_hinzufuegen
            // 
            this.btn_hinzufuegen.Enabled = false;
            this.btn_hinzufuegen.Location = new System.Drawing.Point(160, 247);
            this.btn_hinzufuegen.Name = "btn_hinzufuegen";
            this.btn_hinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_hinzufuegen.TabIndex = 7;
            this.btn_hinzufuegen.Text = "Hinzufügen";
            this.btn_hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_hinzufuegen.Click += new System.EventHandler(this.btn_hinzufuegen_Click);
            // 
            // btn_suche
            // 
            this.btn_suche.Location = new System.Drawing.Point(160, 4);
            this.btn_suche.Name = "btn_suche";
            this.btn_suche.Size = new System.Drawing.Size(75, 23);
            this.btn_suche.TabIndex = 6;
            this.btn_suche.Text = "Suchen";
            this.btn_suche.UseVisualStyleBackColor = true;
            this.btn_suche.Click += new System.EventHandler(this.btn_suche_Click);
            // 
            // txt_suche
            // 
            this.txt_suche.Location = new System.Drawing.Point(6, 6);
            this.txt_suche.Name = "txt_suche";
            this.txt_suche.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_suche.Size = new System.Drawing.Size(120, 20);
            this.txt_suche.TabIndex = 5;
            // 
            // lbx_freunde
            // 
            this.lbx_freunde.FormattingEnabled = true;
            this.lbx_freunde.Location = new System.Drawing.Point(6, 32);
            this.lbx_freunde.Name = "lbx_freunde";
            this.lbx_freunde.Size = new System.Drawing.Size(120, 238);
            this.lbx_freunde.TabIndex = 4;
            this.lbx_freunde.SelectedIndexChanged += new System.EventHandler(this.lbx_freunde_SelectedIndexChanged);
            // 
            // tb_Bibliothek
            // 
            this.tb_Bibliothek.Controls.Add(this.btn_SpielEntfernen);
            this.tb_Bibliothek.Controls.Add(this.btn_SpielStarten);
            this.tb_Bibliothek.Controls.Add(this.lbl_Beschreibung);
            this.tb_Bibliothek.Controls.Add(this.lbl_Titel);
            this.tb_Bibliothek.Controls.Add(this.lbx_Spiele);
            this.tb_Bibliothek.Location = new System.Drawing.Point(4, 22);
            this.tb_Bibliothek.Name = "tb_Bibliothek";
            this.tb_Bibliothek.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Bibliothek.Size = new System.Drawing.Size(515, 275);
            this.tb_Bibliothek.TabIndex = 1;
            this.tb_Bibliothek.Text = "Bibliothek";
            this.tb_Bibliothek.UseVisualStyleBackColor = true;
            this.tb_Bibliothek.Enter += new System.EventHandler(this.tb_Bibliothek_Enter);
            // 
            // btn_SpielEntfernen
            // 
            this.btn_SpielEntfernen.Enabled = false;
            this.btn_SpielEntfernen.Location = new System.Drawing.Point(241, 247);
            this.btn_SpielEntfernen.Name = "btn_SpielEntfernen";
            this.btn_SpielEntfernen.Size = new System.Drawing.Size(75, 23);
            this.btn_SpielEntfernen.TabIndex = 4;
            this.btn_SpielEntfernen.Text = "Entfernen";
            this.btn_SpielEntfernen.UseVisualStyleBackColor = true;
            // 
            // btn_SpielStarten
            // 
            this.btn_SpielStarten.Enabled = false;
            this.btn_SpielStarten.Location = new System.Drawing.Point(160, 247);
            this.btn_SpielStarten.Name = "btn_SpielStarten";
            this.btn_SpielStarten.Size = new System.Drawing.Size(75, 23);
            this.btn_SpielStarten.TabIndex = 3;
            this.btn_SpielStarten.Text = "Starten";
            this.btn_SpielStarten.UseVisualStyleBackColor = true;
            // 
            // lbl_Beschreibung
            // 
            this.lbl_Beschreibung.Location = new System.Drawing.Point(157, 44);
            this.lbl_Beschreibung.Name = "lbl_Beschreibung";
            this.lbl_Beschreibung.Size = new System.Drawing.Size(352, 200);
            this.lbl_Beschreibung.TabIndex = 2;
            this.lbl_Beschreibung.Text = "( Beschreibung )";
            // 
            // lbl_Titel
            // 
            this.lbl_Titel.AutoSize = true;
            this.lbl_Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titel.Location = new System.Drawing.Point(156, 6);
            this.lbl_Titel.Name = "lbl_Titel";
            this.lbl_Titel.Size = new System.Drawing.Size(56, 20);
            this.lbl_Titel.TabIndex = 1;
            this.lbl_Titel.Text = "( Titel )";
            // 
            // lbx_Spiele
            // 
            this.lbx_Spiele.FormattingEnabled = true;
            this.lbx_Spiele.Location = new System.Drawing.Point(6, 6);
            this.lbx_Spiele.Name = "lbx_Spiele";
            this.lbx_Spiele.Size = new System.Drawing.Size(120, 264);
            this.lbx_Spiele.TabIndex = 0;
            this.lbx_Spiele.SelectedIndexChanged += new System.EventHandler(this.lbx_Spiele_SelectedIndexChanged);
            // 
            // tb_Shop
            // 
            this.tb_Shop.Controls.Add(this.lbl_ShopBeschreibung);
            this.tb_Shop.Controls.Add(this.lbl_ShopTitel);
            this.tb_Shop.Controls.Add(this.btn_SpielHinzufuegen);
            this.tb_Shop.Controls.Add(this.btn_SpielSuche);
            this.tb_Shop.Controls.Add(this.txt_sucheSpiel);
            this.tb_Shop.Controls.Add(this.lbx_ShopSpiele);
            this.tb_Shop.Location = new System.Drawing.Point(4, 22);
            this.tb_Shop.Name = "tb_Shop";
            this.tb_Shop.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Shop.Size = new System.Drawing.Size(515, 275);
            this.tb_Shop.TabIndex = 2;
            this.tb_Shop.Text = "Shop";
            this.tb_Shop.UseVisualStyleBackColor = true;
            // 
            // lbl_ShopBeschreibung
            // 
            this.lbl_ShopBeschreibung.Location = new System.Drawing.Point(157, 45);
            this.lbl_ShopBeschreibung.Name = "lbl_ShopBeschreibung";
            this.lbl_ShopBeschreibung.Size = new System.Drawing.Size(352, 200);
            this.lbl_ShopBeschreibung.TabIndex = 13;
            this.lbl_ShopBeschreibung.Text = "( Beschreibung )";
            // 
            // lbl_ShopTitel
            // 
            this.lbl_ShopTitel.AutoSize = true;
            this.lbl_ShopTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShopTitel.Location = new System.Drawing.Point(241, 4);
            this.lbl_ShopTitel.Name = "lbl_ShopTitel";
            this.lbl_ShopTitel.Size = new System.Drawing.Size(56, 20);
            this.lbl_ShopTitel.TabIndex = 12;
            this.lbl_ShopTitel.Text = "( Titel )";
            // 
            // btn_SpielHinzufuegen
            // 
            this.btn_SpielHinzufuegen.Enabled = false;
            this.btn_SpielHinzufuegen.Location = new System.Drawing.Point(160, 247);
            this.btn_SpielHinzufuegen.Name = "btn_SpielHinzufuegen";
            this.btn_SpielHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_SpielHinzufuegen.TabIndex = 11;
            this.btn_SpielHinzufuegen.Text = "Hinzufügen";
            this.btn_SpielHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_SpielHinzufuegen.Click += new System.EventHandler(this.btn_SpielHinzufuegen_Click);
            // 
            // btn_SpielSuche
            // 
            this.btn_SpielSuche.Location = new System.Drawing.Point(160, 4);
            this.btn_SpielSuche.Name = "btn_SpielSuche";
            this.btn_SpielSuche.Size = new System.Drawing.Size(75, 23);
            this.btn_SpielSuche.TabIndex = 10;
            this.btn_SpielSuche.Text = "Suchen";
            this.btn_SpielSuche.UseVisualStyleBackColor = true;
            this.btn_SpielSuche.Click += new System.EventHandler(this.btn_SpielSuche_Click);
            // 
            // txt_sucheSpiel
            // 
            this.txt_sucheSpiel.Location = new System.Drawing.Point(6, 6);
            this.txt_sucheSpiel.Name = "txt_sucheSpiel";
            this.txt_sucheSpiel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_sucheSpiel.Size = new System.Drawing.Size(120, 20);
            this.txt_sucheSpiel.TabIndex = 9;
            // 
            // lbx_ShopSpiele
            // 
            this.lbx_ShopSpiele.FormattingEnabled = true;
            this.lbx_ShopSpiele.Location = new System.Drawing.Point(6, 32);
            this.lbx_ShopSpiele.Name = "lbx_ShopSpiele";
            this.lbx_ShopSpiele.Size = new System.Drawing.Size(120, 238);
            this.lbx_ShopSpiele.TabIndex = 8;
            this.lbx_ShopSpiele.SelectedIndexChanged += new System.EventHandler(this.lbx_ShopSpiele_SelectedIndexChanged);
            // 
            // lbl_User
            // 
            this.lbl_User.Location = new System.Drawing.Point(31, 9);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_User.Size = new System.Drawing.Size(500, 13);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Angemeldet als: ( Name )";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 342);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.tabControl1);
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.tabControl1.ResumeLayout(false);
            this.tb_Freunde.ResumeLayout(false);
            this.tb_Freunde.PerformLayout();
            this.tb_Bibliothek.ResumeLayout(false);
            this.tb_Bibliothek.PerformLayout();
            this.tb_Shop.ResumeLayout(false);
            this.tb_Shop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_Freunde;
        private System.Windows.Forms.TabPage tb_Bibliothek;
        private System.Windows.Forms.Button btn_hinzufuegen;
        private System.Windows.Forms.Button btn_suche;
        private System.Windows.Forms.TextBox txt_suche;
        private System.Windows.Forms.ListBox lbx_freunde;
        private System.Windows.Forms.TabPage tb_Shop;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Titel;
        private System.Windows.Forms.ListBox lbx_Spiele;
        private System.Windows.Forms.Label lbl_Beschreibung;
        private System.Windows.Forms.Button btn_SpielEntfernen;
        private System.Windows.Forms.Button btn_SpielStarten;
        private System.Windows.Forms.Label lbl_ShopBeschreibung;
        private System.Windows.Forms.Label lbl_ShopTitel;
        private System.Windows.Forms.Button btn_SpielHinzufuegen;
        private System.Windows.Forms.Button btn_SpielSuche;
        private System.Windows.Forms.TextBox txt_sucheSpiel;
        private System.Windows.Forms.ListBox lbx_ShopSpiele;
    }
}