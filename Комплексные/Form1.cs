using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Комплексные
{
    
    public partial class Form1 : Form
    {
        double a1, a2, b1, b2;
        string z;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        void sloj(double z1, double z2, double x1, double x2)
        {
            if ((x1 + x2) > 0)
            {
                z = (z1 + z2).ToString() + " + " + (x1 + x2).ToString() + 'i';
            }
            else if ((x1 + x2) < 0)
            {
                z = (z1 + z2).ToString() + (x1 + x2).ToString() + 'i';
            }
            else
            {
                z = (z1 + z2).ToString();
            }
        }
        void umnj(double z1, double z2, double x1, double x2)
        {
            if ((z1 * x2 + x1 * z2) > 0)
            {
                z = (z1 * z2 - x1 * x2).ToString() + " + " + (z1 * x2 + x1 * z2).ToString() + 'i';
            }else if((z1 * x2 + x1 * z2) < 0)
            {
                z = (z1 * z2 - x1 * x2).ToString() + (z1 * x2 + x1 * z2).ToString() + 'i';
            }else
            {
                z = (z1 * z2 - x1 * x2).ToString();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox1.Text);
            a2 = double.Parse(textBox3.Text);
            b1 = double.Parse(textBox2.Text);
            b2 = double.Parse(textBox4.Text);
            sloj(a1, a2, b1, b2);
            textBox5.Text += Environment.NewLine + this.z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1 = double.Parse(textBox1.Text);
            a2 = double.Parse(textBox3.Text);
            b1 = double.Parse(textBox2.Text);
            b2 = double.Parse(textBox4.Text);
            umnj(a1, a2, b1, b2);
            textBox5.Text += Environment.NewLine + this.z;
        }


    }
}
