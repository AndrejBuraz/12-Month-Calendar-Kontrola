using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
            if (ts.Days < 1)
            {

                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;

            }
            else 
            {
                int dani = ts.Days + 1; // ako se ne poveca za jedan uvijek ce ispisivati jeda dan manje od ukupnih odabranih dana
                MessageBox.Show("Rezervirali ste usluge u trajanju od "+ dani.ToString() + " dana.", "Rezervacija");
                MessageBox.Show("Vasa rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " a završava se " + monthCalendar1.SelectionEnd.ToShortDateString());
            }
        }
    }
}
