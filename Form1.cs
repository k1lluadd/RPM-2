using System;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonsLabelsLab2
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.RoyalBlue;
            label1.ForeColor = Color.White;
            label2.BackColor = Color.RoyalBlue;
            label2.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.SeaGreen;
            label3.ForeColor = Color.White;
            label4.BackColor = Color.SeaGreen;
            label4.ForeColor = Color.White;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White; label1.ForeColor = Color.Black;
            label2.BackColor = Color.White; label2.ForeColor = Color.Black;
            label3.BackColor = Color.White; label3.ForeColor = Color.Black;
            label4.BackColor = Color.White; label4.ForeColor = Color.Black;
        }
    }
}
