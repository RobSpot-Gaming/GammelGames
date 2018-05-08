namespace GammelGames
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_games = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_community = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_shop
            // 
            this.btn_shop.Location = new System.Drawing.Point(206, 153);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(128, 112);
            this.btn_shop.TabIndex = 2;
            this.btn_shop.Text = "btn2";
            this.btn_shop.UseVisualStyleBackColor = true;
            this.btn_shop.Visible = false;
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(12, 366);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(128, 112);
            this.btn_user.TabIndex = 4;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Visible = false;
            // 
            // btn_games
            // 
            this.btn_games.BackColor = System.Drawing.Color.DimGray;
            this.btn_games.ForeColor = System.Drawing.Color.Black;
            this.btn_games.Image = global::GammelGames.Properties.Resources.community;
            this.btn_games.Location = new System.Drawing.Point(146, 15);
            this.btn_games.Name = "btn_games";
            this.btn_games.Size = new System.Drawing.Size(128, 112);
            this.btn_games.TabIndex = 0;
            this.btn_games.UseVisualStyleBackColor = false;
            this.btn_games.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GammelGames.Properties.Resources.games;
            this.pictureBox4.Location = new System.Drawing.Point(12, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 111);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GammelGames.Properties.Resources.shop;
            this.pictureBox3.Location = new System.Drawing.Point(12, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GammelGames.Properties.Resources.account;
            this.pictureBox2.Location = new System.Drawing.Point(12, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_community
            // 
            this.btn_community.Image = ((System.Drawing.Image)(resources.GetObject("btn_community.Image")));
            this.btn_community.Location = new System.Drawing.Point(12, 249);
            this.btn_community.Name = "btn_community";
            this.btn_community.Size = new System.Drawing.Size(128, 112);
            this.btn_community.TabIndex = 3;
            this.btn_community.UseVisualStyleBackColor = true;
            this.btn_community.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GammelGames.Properties.Resources.community1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(572, 490);
            this.Controls.Add(this.btn_community);
            this.Controls.Add(this.btn_games);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_shop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_games;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Button btn_community;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

