using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodyy05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int faktorial(int cislo)
        {
            int fakt = 1;

            for (int i = 2; i <= cislo; ++i)
            {
                fakt *= i;
            }

            return fakt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int vysledny_fakt;
            vysledny_fakt = faktorial(n);
            MessageBox.Show("Faktorial je " + vysledny_fakt);
        }
    }
}
