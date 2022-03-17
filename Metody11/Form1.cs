using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int PocetSlov(string s, out string upravenyRetezec)
        {
            char[] oddelovac = { ' ' };
            string[] slova = s.Split(oddelovac, StringSplitOptions.RemoveEmptyEntries);
            int pocetSlov = slova.Length;
            int i;
            upravenyRetezec = s;

            i = 0;
            while (i < upravenyRetezec.Length)
            {
                if (char.IsDigit(upravenyRetezec[i]))
                {
                    upravenyRetezec = upravenyRetezec.Remove(i, 1);
                }
                else ++i;
            }

            return pocetSlov;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string upraveny;
            int pocet = PocetSlov(s, out upraveny);

            MessageBox.Show("Počet slov je " + pocet + "\n" + upraveny);
        }
    }
}
