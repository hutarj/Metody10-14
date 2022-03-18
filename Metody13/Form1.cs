using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JeAlfnum(string s, out int pocetVel, out int pocetMal, out int pocetOst)
        {
            bool jeAlfnum = true;
            pocetVel = 0;
            pocetMal = 0;
            pocetOst = 0;
            foreach (char item in s)
            {
                if(char.IsLetterOrDigit(item) || char.IsWhiteSpace(item))
                {
                    if (char.IsUpper(item)) ++pocetVel;
                    else if (char.IsLower(item)) ++pocetMal;
                }
                else
                {
                    jeAlfnum = false;
                    ++pocetOst;
                }
            }
            return jeAlfnum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int pocetMal;
            int pocetVel;
            int pocetOst;
            if (JeAlfnum(s, out pocetVel, out pocetMal, out pocetOst)) MessageBox.Show("Řetězec je alfnumerický\n" + "Počet velkých písmen - " + pocetVel + "\nPočet malých písmen - " + pocetMal);
            else MessageBox.Show("Řetězec není alfnumerický\n" + "Počet velkých písmen - " + pocetVel + "\nPočet malých písmen - " + pocetMal + "\nPočet ostatních znaků - " + pocetOst);

        }
    }
}
