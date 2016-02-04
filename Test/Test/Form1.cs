using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);

            if (num1 <= 5)
            {
                panel1.BackColor = Color.Green;
            }
            else if (num1 <= 7) 
            { 
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }

        }

    }
}
