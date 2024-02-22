using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj06_TimerObjecten
{
    public partial class frm00_Timers : Form
    {
        int aantalKeer = 0;
        int aantalSeconden = 0;


        public frm00_Timers()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (aantalKeer < 10)
            {
                aantalKeer++;
                lblTekst.Text += "DAAN";
            }
            else
            {
                aantalSeconden += 5;
                timer.Stop();
                if (MessageBox.Show("Je runt nu al " + aantalSeconden.ToString() + " seconden. Wil je verder gaan?", "Verdergaan?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    timer.Start();
                    lblTekst.Text += "\n";
                    aantalKeer = 0;
                }
                else
                {
                    timer.Stop();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
