using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace artırıp__eksiltme
{
    public partial class Form1 : Form
    {
        public static int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
