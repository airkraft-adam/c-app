using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Double a = 0;
        Double b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);            
            b = Double.Parse(textBox2.Text);

            if (a > b)
            {
                label6.Text = a.ToString();
            }
            else
            if (a < b)
            { label6.Text = b.ToString(); }
            else
                label6.Text = "liczby są równe";
        }

    }
}
