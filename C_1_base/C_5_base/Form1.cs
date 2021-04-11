using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_5_base
{
    public partial class Form1 : Form
    {
        string dir;
        string[] dirs, files;

        private void DisplayDir()
        {
            listView1.Clear();
            dirs = Directory.GetDirectories(dir);
            files = Directory.GetFiles(dir);
            foreach (string dirr in dirs)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = dirr.Remove(0, dirr.LastIndexOf('\\') + 1);
                lvi.BackColor = Color.PaleVioletRed;
                listView1.Items.Add(lvi);
            }
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                listView1.Items.Add(lvi);
            }
        }

        public Form1()
        {
            InitializeComponent();
            dir = "C:\\";
            DisplayDir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dir != "C:\\"){
                dir = dir.Remove(dir.Length - 1);
                dir = dir.Remove(dir.LastIndexOf('\\') + 1);
                DisplayDir();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listView1.SelectedItems[0].Text.Contains("."))
            {
                dir += listView1.SelectedItems[0].Text + '\\';
                DisplayDir();
            }
            else
            {
                //open file
                openFileDialog1.InitialDirectory = dir;
                openFileDialog1.FileName = listView1.SelectedItems[0].Text;
                openFileDialog1.ShowDialog();
                DisplayDir();
            }
        }
    }
}
