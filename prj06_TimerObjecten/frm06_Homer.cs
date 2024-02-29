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
    public partial class frm06_Homer : Form {
        public frm06_Homer() {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            //ja
            MessageBox.Show("Je dat klopt.");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Point pt = new Point(rnd.Next(0, 750), rnd.Next(0, 450));

            pictureBox1.Location = pt;
        }
    }
}
