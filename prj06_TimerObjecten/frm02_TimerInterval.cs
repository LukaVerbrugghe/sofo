using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj06_TimerObjecten {
    public partial class frm02_TimerInterval : Form {
        int intgetal = 0;

        public frm02_TimerInterval() {
            InitializeComponent();
            btnStop.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            //interval timer uit txt halen en tmr starten
            timer1.Interval = Convert.ToInt16(txtInterval.Text);
            timer1.Start();

            //btn lock
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e) {
            //timer stoppen
            timer1.Stop();

            //btns
            btnStop.Enabled = false;
            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            //reset
            txtInterval.Text = "";
            lblGetal.Text = "";
            intgetal = 0;

            //btn
            btnReset.Enabled = false;
            btnStart.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            intgetal++;
            lblGetal.Text = intgetal.ToString();
        }
    }
}
