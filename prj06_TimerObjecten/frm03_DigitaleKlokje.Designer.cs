namespace prj06_TimerObjecten {
    partial class frm03_DigitaleKlokje {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblKlokje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKlokje
            // 
            this.lblKlokje.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlokje.Location = new System.Drawing.Point(31, 27);
            this.lblKlokje.Name = "lblKlokje";
            this.lblKlokje.Size = new System.Drawing.Size(620, 138);
            this.lblKlokje.TabIndex = 0;
            this.lblKlokje.Text = "--:--:--:--";
            this.lblKlokje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm03_DigitaleKlokje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(678, 203);
            this.Controls.Add(this.lblKlokje);
            this.Name = "frm03_DigitaleKlokje";
            this.Text = "Digitaal Klokje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKlokje;
        private System.Windows.Forms.Timer timer1;
    }
}