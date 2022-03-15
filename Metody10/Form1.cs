using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ObsahujeCislici(string s, out int cifSoucet, out int soucetLichCif, out int soucetSudCif)
        {
            bool obsahujeCifru = false;
            int cislo;
            cifSoucet = 0;
            soucetLichCif = 0;
            soucetSudCif = 0;
            foreach (char znak in s)
            {
                if (char.IsDigit(znak))
                {
                    obsahujeCifru = true;
                    cislo = Convert.ToInt32(char.ToString(znak));
                    cifSoucet += cislo;
                    if (cislo % 2 == 0) soucetSudCif += cislo;
                    else soucetLichCif += cislo;
                }
            }
            return obsahujeCifru;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int cifSoucet, soucetLichCif, soucetSudCif;

            if (ObsahujeCislici(s, out cifSoucet, out soucetLichCif, out soucetSudCif))
            {
                MessageBox.Show("Součet cifer je " + cifSoucet + "\nSoučet lichých cifer je " + soucetLichCif + "\nSoučet sudých cifer je " + soucetSudCif);
            }
            else MessageBox.Show("Řetězec neobsahuje žádnou cifru");
        }
    }
}
