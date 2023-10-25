using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p=Convert.ToInt32(textBox1.Text);
            int n=Convert.ToInt32(textBox2.Text);
            int r=Convert.ToInt32(textBox3.Text);
            int intrest = p * n * r / 100;
            int final = p + intrest;

            label5.Text = "Intrest: " + intrest.ToString();
            label6.Text = "Final Amount: "+final.ToString();
        }
    }
}
