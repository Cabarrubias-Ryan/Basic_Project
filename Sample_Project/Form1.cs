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
            this.BackColor = Color.Beige;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Khaki;
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
    }
}
