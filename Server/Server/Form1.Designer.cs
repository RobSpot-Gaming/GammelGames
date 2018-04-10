namespace Server
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
            this.tb_SqlName = new System.Windows.Forms.TextBox();
            this.tb_SqlPassword = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_SqlStatus = new System.Windows.Forms.Panel();
            this.lbl_SqlStatus = new System.Windows.Forms.Label();
            this.lbx_Console = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_SqlName
            // 
            this.tb_SqlName.Location = new System.Drawing.Point(65, 19);
            this.tb_SqlName.Name = "tb_SqlName";
            this.tb_SqlName.Size = new System.Drawing.Size(100, 20);
            this.tb_SqlName.TabIndex = 0;
            this.tb_SqlName.Text = "root";
            // 
            // tb_SqlPassword
            // 
            this.tb_SqlPassword.Location = new System.Drawing.Point(65, 45);
            this.tb_SqlPassword.Name = "tb_SqlPassword";
            this.tb_SqlPassword.Size = new System.Drawing.Size(100, 20);
            this.tb_SqlPassword.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(258, 227);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start Server";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_SqlName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_SqlPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySql Anmeldekack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // pn_SqlStatus
            // 
            this.pn_SqlStatus.BackColor = System.Drawing.Color.DarkRed;
            this.pn_SqlStatus.Location = new System.Drawing.Point(18, 101);
            this.pn_SqlStatus.Name = "pn_SqlStatus";
            this.pn_SqlStatus.Size = new System.Drawing.Size(13, 13);
            this.pn_SqlStatus.TabIndex = 4;
            // 
            // lbl_SqlStatus
            // 
            this.lbl_SqlStatus.AutoSize = true;
            this.lbl_SqlStatus.Location = new System.Drawing.Point(34, 101);
            this.lbl_SqlStatus.Name = "lbl_SqlStatus";
            this.lbl_SqlStatus.Size = new System.Drawing.Size(70, 13);
            this.lbl_SqlStatus.TabIndex = 0;
            this.lbl_SqlStatus.Text = "MySql Server";
            // 
            // lbx_Console
            // 
            this.lbx_Console.FormattingEnabled = true;
            this.lbx_Console.Location = new System.Drawing.Point(12, 130);
            this.lbx_Console.Name = "lbx_Console";
            this.lbx_Console.Size = new System.Drawing.Size(222, 121);
            this.lbx_Console.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 262);
            this.Controls.Add(this.lbx_Console);
            this.Controls.Add(this.lbl_SqlStatus);
            this.Controls.Add(this.pn_SqlStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Gammel Games Basic Server 0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SqlName;
        private System.Windows.Forms.TextBox tb_SqlPassword;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_SqlStatus;
        private System.Windows.Forms.Label lbl_SqlStatus;
        private System.Windows.Forms.ListBox lbx_Console;
    }
}

