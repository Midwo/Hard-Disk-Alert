namespace Monitoring_dysków_twardych
{
    partial class ListEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListEmail));
            this.gbAddContact = new System.Windows.Forms.GroupBox();
            this.bAddEmail = new System.Windows.Forms.Button();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.lAddEmail = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bLoadList = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.gbAddContact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddContact
            // 
            this.gbAddContact.Controls.Add(this.bAddEmail);
            this.gbAddContact.Controls.Add(this.tbAddEmail);
            this.gbAddContact.Controls.Add(this.lAddEmail);
            this.gbAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbAddContact.Location = new System.Drawing.Point(268, 27);
            this.gbAddContact.Name = "gbAddContact";
            this.gbAddContact.Size = new System.Drawing.Size(245, 115);
            this.gbAddContact.TabIndex = 25;
            this.gbAddContact.TabStop = false;
            this.gbAddContact.Text = "Dodawanie adresu do listy:";
            // 
            // bAddEmail
            // 
            this.bAddEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddEmail.Enabled = false;
            this.bAddEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bAddEmail.Image = global::Monitoring_dysków_twardych.Properties.Resources.contact_new_3;
            this.bAddEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAddEmail.Location = new System.Drawing.Point(6, 47);
            this.bAddEmail.Name = "bAddEmail";
            this.bAddEmail.Size = new System.Drawing.Size(233, 62);
            this.bAddEmail.TabIndex = 4;
            this.bAddEmail.Text = "Dodaj do listy";
            this.bAddEmail.UseVisualStyleBackColor = false;
            this.bAddEmail.Click += new System.EventHandler(this.bAddEmail_Click);
            this.bAddEmail.DragEnter += new System.Windows.Forms.DragEventHandler(this.bAddEmail_DragEnter);
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Location = new System.Drawing.Point(49, 18);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(190, 23);
            this.tbAddEmail.TabIndex = 3;
            this.tbAddEmail.Text = "xyz@email.pl";
            this.tbAddEmail.TextChanged += new System.EventHandler(this.tbAddEmail_TextChanged);
            this.tbAddEmail.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbAddEmail_DragEnter);
            this.tbAddEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddEmail_KeyDown);
            // 
            // lAddEmail
            // 
            this.lAddEmail.AutoSize = true;
            this.lAddEmail.Location = new System.Drawing.Point(6, 21);
            this.lAddEmail.Name = "lAddEmail";
            this.lAddEmail.Size = new System.Drawing.Size(46, 17);
            this.lAddEmail.TabIndex = 2;
            this.lAddEmail.Text = "Email:";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 16;
            this.lbList.Location = new System.Drawing.Point(6, 19);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(242, 356);
            this.lbList.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 381);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista e-mail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bDelete);
            this.groupBox2.Controls.Add(this.bLoadList);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(268, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 262);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu operacji";
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bDelete.Image = global::Monitoring_dysków_twardych.Properties.Resources.user_trash_full2;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDelete.Location = new System.Drawing.Point(6, 22);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(233, 72);
            this.bDelete.TabIndex = 26;
            this.bDelete.Text = "Wyczyść całą listę";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bLoadList
            // 
            this.bLoadList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bLoadList.Image = global::Monitoring_dysków_twardych.Properties.Resources.folder_documents1;
            this.bLoadList.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bLoadList.Location = new System.Drawing.Point(6, 102);
            this.bLoadList.Name = "bLoadList";
            this.bLoadList.Size = new System.Drawing.Size(233, 72);
            this.bLoadList.TabIndex = 27;
            this.bLoadList.Text = "Załaduj listę";
            this.bLoadList.UseVisualStyleBackColor = false;
            this.bLoadList.Click += new System.EventHandler(this.bLoadList_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bSave.Image = global::Monitoring_dysków_twardych.Properties.Resources.user_desktop1;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bSave.Location = new System.Drawing.Point(6, 182);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(233, 72);
            this.bSave.TabIndex = 28;
            this.bSave.Text = "Zapisz i zatwierdź";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ListEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbAddContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListEmail";
            this.Text = "MD - Hard Disk Alert";
            this.gbAddContact.ResumeLayout(false);
            this.gbAddContact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoadList;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox gbAddContact;
        private System.Windows.Forms.Button bAddEmail;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.Label lAddEmail;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}