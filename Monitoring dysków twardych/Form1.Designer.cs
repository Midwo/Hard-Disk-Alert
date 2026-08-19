namespace Monitoring_dysków_twardych
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbListAlerts = new System.Windows.Forms.ListBox();
            this.cbSelectDisk = new System.Windows.Forms.ComboBox();
            this.bAddAlert = new System.Windows.Forms.Button();
            this.nUDPercentDisk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bClearList = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lBDisk = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lTime = new System.Windows.Forms.Label();
            this.cbChoiceDiskPeriod = new System.Windows.Forms.ComboBox();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lPeriod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDCoIleMinutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cBSeconds = new System.Windows.Forms.ComboBox();
            this.cBHours = new System.Windows.Forms.ComboBox();
            this.cBMinutes = new System.Windows.Forms.ComboBox();
            this.bRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPercentDisk)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinutes)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailConfigurationToolStripMenuItem,
            this.listEmailToolStripMenuItem});
            this.optionsToolStripMenuItem.Image = global::Monitoring_dysków_twardych.Properties.Resources.system_settings;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.optionsToolStripMenuItem.Text = "Opcje";
            // 
            // emailConfigurationToolStripMenuItem
            // 
            this.emailConfigurationToolStripMenuItem.Image = global::Monitoring_dysków_twardych.Properties.Resources.system_password;
            this.emailConfigurationToolStripMenuItem.Name = "emailConfigurationToolStripMenuItem";
            this.emailConfigurationToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.emailConfigurationToolStripMenuItem.Text = "Ustawienia konta e-mail";
            this.emailConfigurationToolStripMenuItem.Click += new System.EventHandler(this.emailConfigurationToolStripMenuItem_Click_1);
            // 
            // listEmailToolStripMenuItem
            // 
            this.listEmailToolStripMenuItem.Image = global::Monitoring_dysków_twardych.Properties.Resources.accessories_dictionary;
            this.listEmailToolStripMenuItem.Name = "listEmailToolStripMenuItem";
            this.listEmailToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listEmailToolStripMenuItem.Text = "Lista e-mail";
            this.listEmailToolStripMenuItem.Click += new System.EventHandler(this.listEmailToolStripMenuItem_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbListAlerts);
            this.groupBox5.Controls.Add(this.cbSelectDisk);
            this.groupBox5.Controls.Add(this.bAddAlert);
            this.groupBox5.Controls.Add(this.nUDPercentDisk);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.bClearList);
            this.groupBox5.Location = new System.Drawing.Point(388, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(383, 235);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wysyłanie alertów:";
            // 
            // lbListAlerts
            // 
            this.lbListAlerts.FormattingEnabled = true;
            this.lbListAlerts.ItemHeight = 16;
            this.lbListAlerts.Location = new System.Drawing.Point(6, 19);
            this.lbListAlerts.Name = "lbListAlerts";
            this.lbListAlerts.Size = new System.Drawing.Size(275, 180);
            this.lbListAlerts.TabIndex = 3;
            // 
            // cbSelectDisk
            // 
            this.cbSelectDisk.FormattingEnabled = true;
            this.cbSelectDisk.Location = new System.Drawing.Point(205, 204);
            this.cbSelectDisk.Name = "cbSelectDisk";
            this.cbSelectDisk.Size = new System.Drawing.Size(91, 24);
            this.cbSelectDisk.TabIndex = 4;
            this.cbSelectDisk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bAddAlert
            // 
            this.bAddAlert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddAlert.Location = new System.Drawing.Point(6, 204);
            this.bAddAlert.Name = "bAddAlert";
            this.bAddAlert.Size = new System.Drawing.Size(193, 25);
            this.bAddAlert.TabIndex = 5;
            this.bAddAlert.Text = "Dodaj alert poniżej";
            this.bAddAlert.UseVisualStyleBackColor = false;
            this.bAddAlert.Click += new System.EventHandler(this.button1_Click);
            // 
            // nUDPercentDisk
            // 
            this.nUDPercentDisk.Location = new System.Drawing.Point(301, 205);
            this.nUDPercentDisk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPercentDisk.Name = "nUDPercentDisk";
            this.nUDPercentDisk.Size = new System.Drawing.Size(49, 22);
            this.nUDPercentDisk.TabIndex = 6;
            this.nUDPercentDisk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "%";
            // 
            // bClearList
            // 
            this.bClearList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bClearList.Location = new System.Drawing.Point(287, 19);
            this.bClearList.Name = "bClearList";
            this.bClearList.Size = new System.Drawing.Size(87, 179);
            this.bClearList.TabIndex = 9;
            this.bClearList.Text = "Wyczyść listę";
            this.bClearList.UseVisualStyleBackColor = false;
            this.bClearList.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lBDisk);
            this.groupBox3.Location = new System.Drawing.Point(5, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 278);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista dysków:";
            // 
            // lBDisk
            // 
            this.lBDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBDisk.Enabled = false;
            this.lBDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBDisk.FormattingEnabled = true;
            this.lBDisk.Location = new System.Drawing.Point(3, 18);
            this.lBDisk.MultiColumn = true;
            this.lBDisk.Name = "lBDisk";
            this.lBDisk.Size = new System.Drawing.Size(374, 257);
            this.lBDisk.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbChoiceDiskPeriod);
            this.groupBox1.Controls.Add(this.lMinutes);
            this.groupBox1.Controls.Add(this.lPeriod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUDCoIleMinutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBSeconds);
            this.groupBox1.Controls.Add(this.cBHours);
            this.groupBox1.Controls.Add(this.cBMinutes);
            this.groupBox1.Location = new System.Drawing.Point(5, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 132);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje - czas sprawdzania dysków";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lTime);
            this.groupBox2.Location = new System.Drawing.Point(7, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 62);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktualny czas:";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTime.Location = new System.Drawing.Point(19, 23);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(60, 24);
            this.lTime.TabIndex = 8;
            this.lTime.Text = "label2";
            // 
            // cbChoiceDiskPeriod
            // 
            this.cbChoiceDiskPeriod.FormattingEnabled = true;
            this.cbChoiceDiskPeriod.Items.AddRange(new object[] {
            "O określonej godzinie",
            "Co określony czas"});
            this.cbChoiceDiskPeriod.Location = new System.Drawing.Point(6, 19);
            this.cbChoiceDiskPeriod.Name = "cbChoiceDiskPeriod";
            this.cbChoiceDiskPeriod.Size = new System.Drawing.Size(363, 24);
            this.cbChoiceDiskPeriod.TabIndex = 22;
            this.cbChoiceDiskPeriod.SelectedIndexChanged += new System.EventHandler(this.cbOptionCheck_SelectedIndexChanged);
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Enabled = false;
            this.lMinutes.Location = new System.Drawing.Point(301, 107);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(38, 16);
            this.lMinutes.TabIndex = 21;
            this.lMinutes.Text = "Minut";
            // 
            // lPeriod
            // 
            this.lPeriod.AutoSize = true;
            this.lPeriod.Enabled = false;
            this.lPeriod.Location = new System.Drawing.Point(145, 105);
            this.lPeriod.Name = "lPeriod";
            this.lPeriod.Size = new System.Drawing.Size(80, 16);
            this.lPeriod.TabIndex = 20;
            this.lPeriod.Text = "Wykonuj co:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(301, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sekunda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(223, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Minuta:";
            // 
            // nUDCoIleMinutes
            // 
            this.nUDCoIleMinutes.Enabled = false;
            this.nUDCoIleMinutes.Location = new System.Drawing.Point(229, 103);
            this.nUDCoIleMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDCoIleMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCoIleMinutes.Name = "nUDCoIleMinutes";
            this.nUDCoIleMinutes.Size = new System.Drawing.Size(62, 22);
            this.nUDCoIleMinutes.TabIndex = 12;
            this.nUDCoIleMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(145, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Godzina:";
            // 
            // cBSeconds
            // 
            this.cBSeconds.DropDownHeight = 290;
            this.cBSeconds.Enabled = false;
            this.cBSeconds.FormattingEnabled = true;
            this.cBSeconds.IntegralHeight = false;
            this.cBSeconds.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBSeconds.Location = new System.Drawing.Point(304, 66);
            this.cBSeconds.Name = "cBSeconds";
            this.cBSeconds.Size = new System.Drawing.Size(65, 24);
            this.cBSeconds.TabIndex = 16;
            // 
            // cBHours
            // 
            this.cBHours.DisplayMember = "0";
            this.cBHours.DropDownHeight = 290;
            this.cBHours.Enabled = false;
            this.cBHours.FormattingEnabled = true;
            this.cBHours.IntegralHeight = false;
            this.cBHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cBHours.Location = new System.Drawing.Point(148, 66);
            this.cBHours.Name = "cBHours";
            this.cBHours.Size = new System.Drawing.Size(65, 24);
            this.cBHours.TabIndex = 14;
            // 
            // cBMinutes
            // 
            this.cBMinutes.DropDownHeight = 290;
            this.cBMinutes.Enabled = false;
            this.cBMinutes.FormattingEnabled = true;
            this.cBMinutes.IntegralHeight = false;
            this.cBMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cBMinutes.Location = new System.Drawing.Point(226, 66);
            this.cBMinutes.Name = "cBMinutes";
            this.cBMinutes.Size = new System.Drawing.Size(65, 24);
            this.cBMinutes.TabIndex = 15;
            // 
            // bRun
            // 
            this.bRun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRun.Location = new System.Drawing.Point(5, 446);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(766, 26);
            this.bRun.TabIndex = 22;
            this.bRun.Text = "Uruchom monitoring";
            this.bRun.UseVisualStyleBackColor = false;
            this.bRun.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(391, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 172);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Podgląd wybranego dysku:";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#.##%";
            series1.Legend = "Legend1";
            series1.Name = "ChartDane";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(374, 151);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 475);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD - Hard Disk Alert";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPercentDisk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleMinutes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmailToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbListAlerts;
        private System.Windows.Forms.ComboBox cbSelectDisk;
        private System.Windows.Forms.Button bAddAlert;
        private System.Windows.Forms.NumericUpDown nUDPercentDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClearList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lBDisk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.ComboBox cbChoiceDiskPeriod;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDCoIleMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBSeconds;
        private System.Windows.Forms.ComboBox cBHours;
        private System.Windows.Forms.ComboBox cBMinutes;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

