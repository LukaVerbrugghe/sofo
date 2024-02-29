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
    public partial class frm03_DigitaleKlokje : Form {
        public frm03_DigitaleKlokje() {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblKlokje.Text = DateTime.Now.ToString("hh:mm:ss:ff");
        }
    }
}
