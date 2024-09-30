using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            groupBox1.BackColor = Color.Beige;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Khaki;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.PasswordChar = '*';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "I am jude";
            this.button1.Text = "Click me!";
            this.Text = "I am you";
        }
    }
}
