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
    public partial class frm01_Slideshow : Form {

        public frm01_Slideshow() {
            InitializeComponent();
            tmrTimer.Start();
        }

        private void tmrTimer_Tick(object sender, EventArgs e) {
            Random random = new Random();
            int randomint = random.Next(0, 3);
            if (randomint == 0)
            {
                pictureBox1.Image = Properties.Resources.Tom1;
            }
            else if(randomint == 1) {
                pictureBox1.Image = Properties.Resources.Tom2;
            }
            else {
                pictureBox1.Image = Properties.Resources.Tom4;
            }
        }
    }
}
