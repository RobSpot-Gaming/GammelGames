namespace GammelGames
{
    partial class Freundeliste
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
            this.lbx_freunde = new System.Windows.Forms.ListBox();
            this.txt_suche = new System.Windows.Forms.TextBox();
            this.btn_suche = new System.Windows.Forms.Button();
            this.btn_hinzufuegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_freunde
            // 
            this.lbx_freunde.FormattingEnabled = true;
            this.lbx_freunde.Location = new System.Drawing.Point(12, 38);
            this.lbx_freunde.Name = "lbx_freunde";
            this.lbx_freunde.Size = new System.Drawing.Size(120, 186);
            this.lbx_freunde.TabIndex = 0;
            this.lbx_freunde.SelectedIndexChanged += new System.EventHandler(this.lbx_freunde_SelectedIndexChanged);
            // 
            // txt_suche
            // 
            this.txt_suche.Location = new System.Drawing.Point(12, 12);
            this.txt_suche.Name = "txt_suche";
            this.txt_suche.Size = new System.Drawing.Size(120, 20);
            this.txt_suche.TabIndex = 1;
            // 
            // btn_suche
            // 
            this.btn_suche.Location = new System.Drawing.Point(138, 10);
            this.btn_suche.Name = "btn_suche";
            this.btn_suche.Size = new System.Drawing.Size(75, 23);
            this.btn_suche.TabIndex = 2;
            this.btn_suche.Text = "Suchen";
            this.btn_suche.UseVisualStyleBackColor = true;
            this.btn_suche.Click += new System.EventHandler(this.btn_suche_Click);
            // 
            // btn_hinzufuegen
            // 
            this.btn_hinzufuegen.Enabled = false;
            this.btn_hinzufuegen.Location = new System.Drawing.Point(138, 201);
            this.btn_hinzufuegen.Name = "btn_hinzufuegen";
            this.btn_hinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btn_hinzufuegen.TabIndex = 3;
            this.btn_hinzufuegen.Text = "Hinzufügen";
            this.btn_hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_hinzufuegen.Click += new System.EventHandler(this.btn_hinzufuegen_Click);
            // 
            // Freundeliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_hinzufuegen);
            this.Controls.Add(this.btn_suche);
            this.Controls.Add(this.txt_suche);
            this.Controls.Add(this.lbx_freunde);
            this.Name = "Freundeliste";
            this.Text = "Freundeliste";
            this.Load += new System.EventHandler(this.Freundeliste_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Freundeliste_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_freunde;
        private System.Windows.Forms.TextBox txt_suche;
        private System.Windows.Forms.Button btn_suche;
        private System.Windows.Forms.Button btn_hinzufuegen;
    }
}