using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Identicke(string s1, string s2, out int pocetOdlisnosti, out int indexPrvniOdlisnosti)
        {
            bool jsouIdenticke = (string.Compare(s1, s2)) == 0;
            pocetOdlisnosti = 0;
            indexPrvniOdlisnosti = -1;
            if (!jsouIdenticke)
            {
                int max = Math.Max(s1.Length, s2.Length);
                int min = Math.Min(s1.Length, s2.Length);
                pocetOdlisnosti = 0;
                for (int i = 0; i < min; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        if (indexPrvniOdlisnosti == -1) indexPrvniOdlisnosti = i;
                        ++pocetOdlisnosti;
                    }
                }
                if (indexPrvniOdlisnosti == -1) indexPrvniOdlisnosti = min;
                int rozdilVDelce = max - min;
                pocetOdlisnosti += rozdilVDelce;
            }
            return jsouIdenticke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            int pocetOdlisnosti;
            int indexPrvniOdlistnosti;
            if (Identicke(s1, s2, out pocetOdlisnosti, out indexPrvniOdlistnosti)) MessageBox.Show("Řetězce jsou identické");
            else MessageBox.Show("Řetězce nejsou identické\nPočet odlišností - " + pocetOdlisnosti + "\nIndex první odlišnosti - " + indexPrvniOdlistnosti);
        }
    }
}
