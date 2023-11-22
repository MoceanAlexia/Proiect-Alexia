using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Alexia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 but1 = new Form2();
            but1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 but3 = new Form5();
            but3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 but2 = new Form4();
            but2.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 but4 = new Form3();
            but4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 but5 = new Form6();
            but5.Show();
        }
    }
}
