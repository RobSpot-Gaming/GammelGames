namespace GammelGames
{
    partial class Anmeldung
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
            this.txt_passwort = new System.Windows.Forms.TextBox();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.btn_anmelden = new System.Windows.Forms.Button();
            this.btn_registrieren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fehler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_passwort
            // 
            this.txt_passwort.Location = new System.Drawing.Point(78, 53);
            this.txt_passwort.Name = "txt_passwort";
            this.txt_passwort.PasswordChar = '~';
            this.txt_passwort.Size = new System.Drawing.Size(100, 20);
            this.txt_passwort.TabIndex = 1;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Location = new System.Drawing.Point(78, 30);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(100, 20);
            this.txt_nickname.TabIndex = 0;
            // 
            // btn_anmelden
            // 
            this.btn_anmelden.Location = new System.Drawing.Point(12, 114);
            this.btn_anmelden.Name = "btn_anmelden";
            this.btn_anmelden.Size = new System.Drawing.Size(75, 23);
            this.btn_anmelden.TabIndex = 2;
            this.btn_anmelden.Text = "Anmelden";
            this.btn_anmelden.UseVisualStyleBackColor = true;
            this.btn_anmelden.Click += new System.EventHandler(this.btn_anmelden_Click);
            // 
            // btn_registrieren
            // 
            this.btn_registrieren.Location = new System.Drawing.Point(12, 143);
            this.btn_registrieren.Name = "btn_registrieren";
            this.btn_registrieren.Size = new System.Drawing.Size(75, 23);
            this.btn_registrieren.TabIndex = 3;
            this.btn_registrieren.Text = "Registrieren";
            this.btn_registrieren.UseVisualStyleBackColor = true;
            this.btn_registrieren.Click += new System.EventHandler(this.btn_registrieren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nickname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort";
            // 
            // lbl_fehler
            // 
            this.lbl_fehler.AutoSize = true;
            this.lbl_fehler.ForeColor = System.Drawing.Color.Red;
            this.lbl_fehler.Location = new System.Drawing.Point(12, 214);
            this.lbl_fehler.Name = "lbl_fehler";
            this.lbl_fehler.Size = new System.Drawing.Size(0, 13);
            this.lbl_fehler.TabIndex = 7;
            this.lbl_fehler.Visible = false;
            // 
            // Anmeldung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_fehler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registrieren);
            this.Controls.Add(this.btn_anmelden);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.txt_passwort);
            this.Name = "Anmeldung";
            this.Text = "Anmeldung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_passwort;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Button btn_anmelden;
        private System.Windows.Forms.Button btn_registrieren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fehler;
    }
}