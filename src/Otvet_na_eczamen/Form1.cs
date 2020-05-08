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

namespace Otvet_na_eczamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(open.FileName);
                this.WindowState = FormWindowState.Maximized;
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            string otvetka = "";
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) > 9 && x > -3 && x < 3 && y > -3 && y < 3 && ((x > 0 && y < 0) && (y < 0 || x < 0) && y < 0 || (x > 0 && y > 0))))
            {
                otvetka = "Принадлежит!";
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) == 9
            || (x == 3 && (y >= -3 && y <= 3))
            || (x == -3 && (y >= -3 && y <= 0))
            || (y == 3 && (x >= 0 && x <= 3))
            || (y == -3 && (x >= -3 && x <= 3)))
            {
                otvetka = "На границе!";
            }
            else
            {
                otvetka = "Не принадлежит!";
            }
            MessageBox.Show(otvetka);
            toolStripStatusLabel2.Text = otvetka;
        
        }
    }
}

