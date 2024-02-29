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
    public partial class frm04_Chronometer : Form {
        public frm04_Chronometer() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            //timer starten
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (Convert.ToInt16(txtChrono.Text) > 0)
            {
                txtChrono.Text = Convert.ToString(Convert.ToInt16(txtChrono.Text) - 1);
            }
            else
            {
                timer1.Stop();
                label2.Text = "Je tijd is over";
            }
        }

        private void Wis_Click(object sender, EventArgs e) {
            txtChrono.Text = "";
        }
    }
}
