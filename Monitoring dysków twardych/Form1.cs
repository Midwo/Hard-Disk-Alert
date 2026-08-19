using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring_dysków_twardych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lTime.Text = "";
            timer1.Start();
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring dysków");
            Reflesh = DateTime.Now;

            try
            {
                if (key.SubKeyCount > 0)
                {
                    if (key.GetValue("Hour").ToString() != string.Empty || key.GetValue("Minute").ToString() != string.Empty || key.GetValue("Second").ToString() != string.Empty)
                    {
                        cBHours.SelectedItem = key.GetValue("Hour");
                        cBMinutes.SelectedItem = key.GetValue("Minute");
                        cBSeconds.SelectedItem = key.GetValue("Second");
                        nUDCoIleMinutes.Value = Convert.ToUInt32(key.GetValue("NumericMinute"));
                    }
                }
                else
                {
                    cBHours.SelectedItem = "00";
                    cBMinutes.SelectedItem = "00";
                    cBSeconds.SelectedItem = "00";
                    nUDCoIleMinutes.Value = 1;
                }
            }
            catch
            {
                cBHours.SelectedItem = "00";
                cBMinutes.SelectedItem = "00";
                cBSeconds.SelectedItem = "00";
                nUDCoIleMinutes.Value = 1;
            }
            key.Close();

            DriveInfo[] iDrvs = DriveInfo.GetDrives();
            foreach (var Drv in iDrvs)
            {
                if (Drv.IsReady)
                {
                    lBDisk.Items.Add("Nazwa dysku: " + Drv.Name + " dostępne: " + (Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024).ToString("n2") +
                        " GB z " + (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024).ToString("n2") + " GB, stanowi to: "
                        + (((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100).ToString("n2") + "%");
                    cbSelectDisk.Items.Add(Drv.Name);
                    _availableDiskSpaceGlobal += ((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024));
                    _totalDiskSpaceGlobal += (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024);
                }
            }
            var totalDiskSpace = ((Convert.ToDecimal(_availableDiskSpaceGlobal) / (Convert.ToDecimal(_totalDiskSpaceGlobal))));
            var occupiedDiskSpace = ((((Convert.ToDecimal(_totalDiskSpaceGlobal)) - (Convert.ToDecimal(_availableDiskSpaceGlobal))) / (Convert.ToDecimal(_totalDiskSpaceGlobal))));
            //  this.chart1.Series["ChartDane"].Points.AddXY("Total Available: "+(totalDiskSpace*100).ToString("n2")+"%", totalDiskSpace);
            //  this.chart1.Series["ChartDane"].Points.AddXY("Total Occupied: "+(totalDiskSpace*100).ToString("n2")+"%", occupiedDiskSpace);
            this.chart1.Series["ChartDane"].Points.AddXY("Całość dostępna    ", totalDiskSpace);
              this.chart1.Series["ChartDane"].Points.AddXY("Całość zajęta", occupiedDiskSpace);
        }
        Decimal _totalDiskSpaceGlobal;
        Decimal _availableDiskSpaceGlobal;
        Dictionary<string, int> _diskNamePercentAvailableSpace = new Dictionary<string, int>();
        bool _isActiveButton = false;
        DateTime _dateMonit;
        string _connectionCombobox;
        DateTime Reflesh;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lTime.Text = DateTime.Now.ToLongTimeString();
            //if (ActiveButton == true)
            //{
            //    if (System.DateTime.Now.ToLongTimeString() == textBox1.Text)
            //    {

            //        MessageBox.Show("To small hard disc");
            //    }
            //}
            
            if (DateTime.Now > Reflesh)
            {
                Reflesh = DateTime.Now.AddSeconds(15);
                DriveInfo[] refleshDrvs = DriveInfo.GetDrives();
                lBDisk.Items.Clear();

                foreach (var Drv in refleshDrvs)
                {
                    if (Drv.IsReady)
                    {
                        lBDisk.Items.Add("Nazwa dysku: " + Drv.Name + " dostępne: " + (Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024).ToString("n2") +
                            " GB z " + (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024).ToString("n2") + " GB, stanowi to: "
                            + (((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100).ToString("n2") + "%");
                    }
                }
            }
           
            if (_isActiveButton == true)
            {
                var startData = DateTime.Now.ToString("hh.mm.ss.ffffff");

                if (cbChoiceDiskPeriod.SelectedIndex == 0)
                {
                    DateTime changeCombine = DateTime.Parse((_dateMonit.ToString("yyyy/MM/dd") + " " + _connectionCombobox));

                    if (changeCombine <= DateTime.Now)
                    {
                        _dateMonit = DateTime.Parse((DateTime.Now.AddDays(1).ToString("yyyy/MM/dd") + " " + _connectionCombobox));

                        DriveInfo[] yDrvs = DriveInfo.GetDrives();
                        foreach (var Drv in yDrvs)
                        {
                            if (Drv.IsReady)
                            {
                                
                                if (!_diskNamePercentAvailableSpace.TryGetValue("" + Drv.Name + "", out int actualValue))
                                {

                                }
                                else
                                {
                                    var currentPercent = (((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100);
                                    var selectedPercent = (Convert.ToDecimal(_diskNamePercentAvailableSpace["" + Drv.Name + ""]));

                                        
                                    if (currentPercent >= selectedPercent)
                                    {
                                        //  MessageBox.Show("" + (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""]) + ""));
                                    }//["" + Drv.Name.Substring(0, Drv.Name.Length - 1) + ""]
                                    else
                                    {
                                        try
                                        {
                                            Microsoft.Win32.RegistryKey key;
                                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring dysków");

                                            //  MessageBox.Show("wysyłamy wiadomość na temat dysku: " + Drv.Name + "");
                                            int port = Int32.Parse(key.GetValue("Port").ToString());
                                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                            mailServer.EnableSsl = true;

                                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                            MailMessage msg = new MailMessage();
                                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());

                                            EmailConf stringListEmail = new EmailConf();
                                            string emaile = stringListEmail.ToString();


                                            foreach (string email in EmailConf.ListEmail)
                                            {
                                                msg.To.Add(email);
                                            }


                                            msg.Subject = "Ticket - Uwaga Serwer - Mało miejsca";
                                            msg.Body = "Witaj, nie ma wystarczającego miejsca na dysku: " + Drv.Name + " ";

                                            mailServer.Send(msg);

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }

                            }
                        }

                        var stopdata = DateTime.Now.ToString("hh.mm.ss.ffffff");
                        MessageBox.Show("Proces trwał od: " + startData + ", do: " + stopdata + "", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (_dateMonit <= DateTime.Now)
                    {
                        _dateMonit = DateTime.Now.AddMinutes(Convert.ToDouble(nUDCoIleMinutes.Value));


                        DriveInfo[] yDrvs = DriveInfo.GetDrives();
                        foreach (var Drv in yDrvs)
                        {
                            if (Drv.IsReady)
                            {

                                if (!_diskNamePercentAvailableSpace.TryGetValue("" + Drv.Name + "", out int actualValue))
                                {

                                }
                                else
                                {

                                    var currentPercent = (((Convert.ToDecimal(Drv.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv.TotalSize) / 1024 / 1024 / 1024)) * 100);
                                    var selectedPercent = (Convert.ToDecimal(_diskNamePercentAvailableSpace["" + Drv.Name + ""]));


                                    if (currentPercent >= selectedPercent)
                                    {
                                        //  MessageBox.Show("" + (Convert.ToDecimal(DiscNameAndPercent["" + Drv.Name + ""]) + ""));
                                    }//["" + Drv.Name.Substring(0, Drv.Name.Length - 1) + ""]
                                    else
                                    {
                                        try
                                        {
                                            Microsoft.Win32.RegistryKey key;
                                            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring dysków");

                                            int port = Int32.Parse(key.GetValue("Port").ToString());
                                            SmtpClient mailServer = new SmtpClient(key.GetValue("SMTP").ToString(), port);
                                            mailServer.EnableSsl = true;

                                            mailServer.Credentials = new System.Net.NetworkCredential(key.GetValue("Name").ToString(), key.GetValue("Password").ToString());

                                            MailMessage msg = new MailMessage();
                                            msg.From = new MailAddress(key.GetValue("Name").ToString(), key.GetValue("Signature").ToString());

                                            EmailConf stringListEmail = new EmailConf();
                                            string emaile = stringListEmail.ToString();


                                            foreach (string email in EmailConf.ListEmail)
                                            {
                                                msg.To.Add(email);
                                            }

                                            msg.Subject = "Ticket - Uwaga Serwer - Mało miejsca";
                                            msg.Body = "Witaj, nie ma wystarczającego miejsca na dysku: " + Drv.Name + " ";

                                            mailServer.Send(msg);

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        var stopdata = DateTime.Now.ToString("hh.mm.ss.ffffff");
                        MessageBox.Show("Proces trwał od: " + startData + ", do: " + stopdata + "", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }          
            }
        }

        private void cbOptionCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoiceDiskPeriod.SelectedIndex == 0)
            {
                cBHours.Enabled = true;
                cBMinutes.Enabled = true;
                cBSeconds.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                nUDCoIleMinutes.Enabled = false;
                lPeriod.Enabled = false;
                lMinutes.Enabled = false;

            }
            else if (cbChoiceDiskPeriod.SelectedIndex == 1)
            {
                cBHours.Enabled = false;
                cBMinutes.Enabled = false;
                cBSeconds.Enabled = false;
                nUDCoIleMinutes.Enabled = true;
                lPeriod.Enabled = true;
                lMinutes.Enabled = true;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
        }

        private void emailConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfEmail m = new ConfEmail();
            m.Show();
        }

        private void listEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmail m = new ListEmail();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbListAlerts.Items.Clear();
            _diskNamePercentAvailableSpace.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _diskNamePercentAvailableSpace.Add(cbSelectDisk.Text, Convert.ToInt32(nUDPercentDisk.Value));
                lbListAlerts.Items.Add(cbSelectDisk.SelectedItem.ToString() + " alert poniżej: " + nUDPercentDisk.Value + " %");
            }
            catch
            {
                MessageBox.Show("Musisz wybrać inny dysk", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chart1.Series["ChartDane"].Points.Clear();

            DriveInfo[] iDrvs = DriveInfo.GetDrives();
            foreach (var Drv1 in iDrvs)
            {
                if (Drv1.IsReady)
                {
                    if (Drv1.Name == cbSelectDisk.SelectedItem.ToString())
                    {
                        var availableSpace = (((Convert.ToDecimal(Drv1.AvailableFreeSpace) / 1024 / 1024 / 1024) / (Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024)));
                        var occupiedSpace = ((((Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024) - (Convert.ToDecimal(Drv1.AvailableFreeSpace) / 1024 / 1024 / 1024)) / (Convert.ToDecimal(Drv1.TotalSize) / 1024 / 1024 / 1024)));

                        //this.chart1.Series["ChartDane"].Points.AddXY("Available size: "+(availableSpace*100).ToString("n2")+"%", availableSpace);
                        //this.chart1.Series["ChartDane"].Points.AddXY("Occupied size: "+(occupiedSpace*100).ToString("n2")+"%", occupiedSpace);
                        this.chart1.Series["ChartDane"].Points.AddXY("Dostępne miejsce  ", availableSpace);
                        this.chart1.Series["ChartDane"].Points.AddXY("Zajęte miejsce ", occupiedSpace);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbListAlerts.Items.Count > 0)
            {
                EmailConf stringListEmail = new EmailConf();

                try
                {
                    if (stringListEmail.StringListEmail().Trim().Length > 1)
                    {
                        if (cbChoiceDiskPeriod.SelectedIndex != -1)
                        {
                            try
                            {
                                Microsoft.Win32.RegistryKey key;
                                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MD - Monitoring dysków");
                                string password = key.GetValue("Port").ToString();

                                _dateMonit = DateTime.Now.AddSeconds(Convert.ToDouble(nUDCoIleMinutes.Value));
                                bRun.Text = "Monitoruję";
                                _isActiveButton = true;
                                _connectionCombobox = cBHours.SelectedItem + ":" + cBMinutes.SelectedItem + ":" + cBSeconds.SelectedItem;


                                key.SetValue("Hour", cBHours.SelectedItem);
                                key.SetValue("Minute", cBMinutes.SelectedItem);
                                key.SetValue("Second", cBSeconds.SelectedItem);
                                key.SetValue("NumericMinute", nUDCoIleMinutes.Value);
                                key.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Przed uruchomieniem monitorowania należy skonfigurować konto email do wysyłania wiadomości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Musisz wybrać 'Opcje - czas sprawdzania dysków'", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Musisz załadować listę e-maili i zapisać ją", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Musisz załadować listę e-maili i zapisać ją", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Musisz dodać dyski do sprawdzania - listy!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void emailConfigurationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfEmail x = new ConfEmail();
                x.Show();
        }

        private void listEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListEmail x = new ListEmail();
            x.Show();
        }
    }
}
