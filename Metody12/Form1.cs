using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ObsahujeSlovo(string s, out string nejdelsi, out string nejkratsi)
        {
            char[] oddelovac = { ' ' };
            string[] slova = s.Split(oddelovac, StringSplitOptions.RemoveEmptyEntries);
            nejkratsi = null;
            nejdelsi = null;
            bool obsahujeSlovo = slova.Length > 0;

            if(obsahujeSlovo)
            {
                nejdelsi = slova[0];
                nejkratsi = slova[0];

                foreach (string item in slova)
                {
                    if (item.Length > nejdelsi.Length) nejdelsi = item;
                    if (item.Length < nejkratsi.Length) nejkratsi = item;
                }
            }

            return obsahujeSlovo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string nejdelsi, nejkratsi;
            if (ObsahujeSlovo(s, out nejdelsi, out nejkratsi))
            {
                MessageBox.Show("Řetězec obsahuje alespoň jedno slovo\nNejdelší slovo - " + nejdelsi + "\nNejkratší slovo - " + nejkratsi);
            }
            else MessageBox.Show("Řetězec neobsahuje alespoň jedno slovo");
        }
    }
}
