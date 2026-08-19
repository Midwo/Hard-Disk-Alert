namespace Monitoring_dysków_twardych
{
    partial class ConfEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfEmail));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbConfServer = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.lSmtp = new System.Windows.Forms.Label();
            this.gbConfEmail = new System.Windows.Forms.GroupBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.tbEmailName = new System.Windows.Forms.TextBox();
            this.lSignature = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lNazwaKonta = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbConfServer.SuspendLayout();
            this.gbConfEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbConfServer
            // 
            this.gbConfServer.Controls.Add(this.tbPort);
            this.gbConfServer.Controls.Add(this.tbSmtp);
            this.gbConfServer.Controls.Add(this.lPort);
            this.gbConfServer.Controls.Add(this.lSmtp);
            this.gbConfServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbConfServer.Location = new System.Drawing.Point(333, 27);
            this.gbConfServer.Name = "gbConfServer";
            this.gbConfServer.Size = new System.Drawing.Size(194, 73);
            this.gbConfServer.TabIndex = 13;
            this.gbConfServer.TabStop = false;
            this.gbConfServer.Text = "Konfiguracja serwera";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(56, 44);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(131, 23);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "587";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(56, 17);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(131, 23);
            this.tbSmtp.TabIndex = 2;
            this.tbSmtp.Text = "smtp.gmail.com";
            this.tbSmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(6, 46);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(38, 17);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port:";
            // 
            // lSmtp
            // 
            this.lSmtp.AutoSize = true;
            this.lSmtp.Location = new System.Drawing.Point(6, 20);
            this.lSmtp.Name = "lSmtp";
            this.lSmtp.Size = new System.Drawing.Size(50, 17);
            this.lSmtp.TabIndex = 0;
            this.lSmtp.Text = "SMTP:";
            // 
            // gbConfEmail
            // 
            this.gbConfEmail.Controls.Add(this.mtbPassword);
            this.gbConfEmail.Controls.Add(this.tbSignature);
            this.gbConfEmail.Controls.Add(this.tbEmailName);
            this.gbConfEmail.Controls.Add(this.lSignature);
            this.gbConfEmail.Controls.Add(this.lPassword);
            this.gbConfEmail.Controls.Add(this.lNazwaKonta);
            this.gbConfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbConfEmail.Location = new System.Drawing.Point(3, 27);
            this.gbConfEmail.Name = "gbConfEmail";
            this.gbConfEmail.Size = new System.Drawing.Size(324, 129);
            this.gbConfEmail.TabIndex = 12;
            this.gbConfEmail.TabStop = false;
            this.gbConfEmail.Text = "Konfiguracja adresu e-mail";
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(66, 59);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.Size = new System.Drawing.Size(252, 23);
            this.mtbPassword.TabIndex = 6;
            this.mtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(66, 97);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(252, 23);
            this.tbSignature.TabIndex = 5;
            this.tbSignature.Text = "Your signature";
            this.tbSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmailName
            // 
            this.tbEmailName.Location = new System.Drawing.Point(65, 22);
            this.tbEmailName.Name = "tbEmailName";
            this.tbEmailName.Size = new System.Drawing.Size(253, 23);
            this.tbEmailName.TabIndex = 3;
            this.tbEmailName.Text = "xyz@gmail.com";
            this.tbEmailName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSignature
            // 
            this.lSignature.AutoSize = true;
            this.lSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lSignature.Location = new System.Drawing.Point(5, 100);
            this.lSignature.Name = "lSignature";
            this.lSignature.Size = new System.Drawing.Size(55, 17);
            this.lSignature.TabIndex = 2;
            this.lSignature.Text = "Podpis:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lPassword.Location = new System.Drawing.Point(5, 62);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(48, 17);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Hasło:";
            // 
            // lNazwaKonta
            // 
            this.lNazwaKonta.AutoSize = true;
            this.lNazwaKonta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lNazwaKonta.Location = new System.Drawing.Point(5, 25);
            this.lNazwaKonta.Name = "lNazwaKonta";
            this.lNazwaKonta.Size = new System.Drawing.Size(54, 17);
            this.lNazwaKonta.TabIndex = 0;
            this.lNazwaKonta.Text = "Nazwa:";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.BackgroundImage = global::Monitoring_dysków_twardych.Properties.Resources.dialog_apply;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSave.Location = new System.Drawing.Point(461, 103);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(66, 53);
            this.bSave.TabIndex = 15;
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(333, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Test konfiguracji";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(531, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbConfServer);
            this.Controls.Add(this.gbConfEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfEmail";
            this.Text = "MD - Hard Disk Alert";
            this.gbConfServer.ResumeLayout(false);
            this.gbConfServer.PerformLayout();
            this.gbConfEmail.ResumeLayout(false);
            this.gbConfEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbConfServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lSmtp;
        private System.Windows.Forms.GroupBox gbConfEmail;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.TextBox tbEmailName;
        private System.Windows.Forms.Label lSignature;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lNazwaKonta;
        private System.Windows.Forms.Button button1;
    }
}