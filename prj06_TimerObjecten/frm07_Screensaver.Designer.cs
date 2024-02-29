namespace prj06_TimerObjecten
{
    partial class frm07_Screensaver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStarten = new System.Windows.Forms.Button();
            this.btnStoppen = new System.Windows.Forms.Button();
            this.rdbGroot = new System.Windows.Forms.RadioButton();
            this.rdbKlein = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 393);
            this.trackBar1.Maximum = 4000;
            this.trackBar1.Minimum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(155, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStarten
            // 
            this.btnStarten.Location = new System.Drawing.Point(241, 408);
            this.btnStarten.Name = "btnStarten";
            this.btnStarten.Size = new System.Drawing.Size(75, 23);
            this.btnStarten.TabIndex = 1;
            this.btnStarten.Text = "Starten";
            this.btnStarten.UseVisualStyleBackColor = true;
            this.btnStarten.Click += new System.EventHandler(this.btnStarten_Click);
            // 
            // btnStoppen
            // 
            this.btnStoppen.Location = new System.Drawing.Point(378, 408);
            this.btnStoppen.Name = "btnStoppen";
            this.btnStoppen.Size = new System.Drawing.Size(75, 23);
            this.btnStoppen.TabIndex = 1;
            this.btnStoppen.Text = "Stoppen";
            this.btnStoppen.UseVisualStyleBackColor = true;
            // 
            // rdbGroot
            // 
            this.rdbGroot.AutoSize = true;
            this.rdbGroot.Location = new System.Drawing.Point(494, 393);
            this.rdbGroot.Name = "rdbGroot";
            this.rdbGroot.Size = new System.Drawing.Size(103, 17);
            this.rdbGroot.TabIndex = 2;
            this.rdbGroot.Text = "Grote afbeelding";
            this.rdbGroot.UseVisualStyleBackColor = true;
            // 
            // rdbKlein
            // 
            this.rdbKlein.AutoSize = true;
            this.rdbKlein.Location = new System.Drawing.Point(494, 416);
            this.rdbKlein.Name = "rdbKlein";
            this.rdbKlein.Size = new System.Drawing.Size(106, 17);
            this.rdbKlein.TabIndex = 2;
            this.rdbKlein.Text = "Kleine afbeelding";
            this.rdbKlein.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm07_Screensaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbKlein);
            this.Controls.Add(this.rdbGroot);
            this.Controls.Add(this.btnStoppen);
            this.Controls.Add(this.btnStarten);
            this.Controls.Add(this.trackBar1);
            this.Name = "frm07_Screensaver";
            this.Text = "Screensaver";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStarten;
        private System.Windows.Forms.Button btnStoppen;
        private System.Windows.Forms.RadioButton rdbGroot;
        private System.Windows.Forms.RadioButton rdbKlein;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}