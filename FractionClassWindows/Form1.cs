using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionClassWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction t = Fraction.Parse(textBox1.Text);
            listBox1.Items.Add(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < listBox1.Height; i++)
            {
                if(textBox1.Text == listBox1.Text)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction a = new Fraction(0, 1);
            
            for (int i = 0; i < listBox1.Height; i++)
            {
                Fraction f = Fraction.Parse(listBox1.Items[i].ToString());
                a = a.Somma(f);
            }

            label1.Text = string.Format("{0}", a);
        }
    }
}
