using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Diskriminant(int a, int b, int c)
        {
            double diskriminant = b * b - 4 * a * c;
            return diskriminant;
        }

        private bool KvadratickaRovnice(int a, int b, int c, out double x1, out double x2)
        {
            double d = Diskriminant(a,b,c);
            bool reseni = d >= 0;
            x1 = 0;
            x2 = 0;
            if (reseni)
            {
                //Vetsi nez nula
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d) / (2 * a));
                    x2 = (-b - Math.Sqrt(d) / (2 * a));
                }
                //Rovno nule
                else
                {

                }
            }


            return reseni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            double x1, x2;
            if (KvadratickaRovnice(a, b, c, out x1, out x2)) MessageBox.Show("x1 = " + x1 + "\nx2 = " + x2);
        }
    }
}
