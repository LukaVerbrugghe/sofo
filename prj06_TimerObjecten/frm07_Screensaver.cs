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
    public partial class frm07_Screensaver : Form
    {
        public frm07_Screensaver()
        {
            InitializeComponent();
        }

        private void btnStarten_Click(object sender, EventArgs e)
        {
            if (rdbGroot.Checked || rdbKlein.Checked)
            {
                //gamecode
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Je moet wel een formaat kiezen he tamzak.");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
