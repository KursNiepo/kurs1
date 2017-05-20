using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWykonaj_Click(object sender, EventArgs e)
        {
            if (tbA.Text.Trim() != "" && tbB.Text.Trim() != "")
            {
                try
                {
                    int a = Convert.ToInt32(tbA.Text);
                    int b = Convert.ToInt32(tbB.Text);
                    NWD nwd = new NWD(a, b);
                    int wynik = nwd.GetNWD();
                    lbWynik.Text = wynik.ToString();
                }
                catch (FormatException)
                {
                    lbWynik.Text = "Błędne dane";
                }
            }
            else
            {
                lbWynik.Text = "Błędne dane";
            }
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-'
                 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
