using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring_dysków_twardych
{
    public partial class ListEmail : Form
    {
        public ListEmail()
        {
            InitializeComponent();
        }
     
        private void bSave_Click(object sender, EventArgs e)
        {
            if (lbList.Items.Count > 0)
            {
                const string sPath = "MD_Lista_Email.txt";

                ArrayList myAL = new ArrayList();
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in lbList.Items)
                {
                    SaveFile.WriteLine(item);
                    myAL.Add(item);
                }
                EmailConf.ListEmail = myAL;

                SaveFile.Close();

                MessageBox.Show("Zapisano poprawnie listę - znajduje się ona w miejscu przetrzymywania pliku .exe programu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie można zapisać pustej listy!", "Uwaga błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bLoadList_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                lbList.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f1.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        lbList.Items.Add(line);
                        if (!lbList.Items.Contains(line.Trim()))
                        {
                            lbList.Items.Add(line);
                        }
                    }
                }
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            lbList.Items.Clear();
        }

        private void bAddEmail_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (tbAddEmail.Text.Length > 0 && tbAddEmail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(tbAddEmail.Text.Trim()))
                {
                    MessageBox.Show("Błędny format email", "Uwaga błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAddEmail.SelectAll();

                }
                else
                {
                    if (!lbList.Items.Contains(tbAddEmail.Text.Trim()))
                    {
                        lbList.Items.Add(tbAddEmail.Text.Trim());

                        tbAddEmail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Już jest taki email wprowadzony", "Uwaga błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                
            }
        }

        private void tbAddEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbAddEmail.Text == "")
            {
                bAddEmail.Enabled = false;
            }
            else
            {
                bAddEmail.Enabled = true;
            }
        }

        private void tbAddEmail_DragEnter(object sender, DragEventArgs e)
        {
            bAddEmail_Click(sender, null);
        }

        private void tbAddEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                bAddEmail_Click(sender, null);
            }
        }

        private void bAddEmail_DragEnter(object sender, DragEventArgs e)
        {
            bAddEmail_Click(sender, null);
        }
    }
}
