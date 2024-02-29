namespace prj06_TimerObjecten {
    partial class frm04_Chronometer {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChrono = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Wis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef je seconden in:";
            // 
            // txtChrono
            // 
            this.txtChrono.Location = new System.Drawing.Point(118, 96);
            this.txtChrono.Name = "txtChrono";
            this.txtChrono.Size = new System.Drawing.Size(100, 20);
            this.txtChrono.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(55, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start chrono";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Wis
            // 
            this.Wis.Location = new System.Drawing.Point(178, 170);
            this.Wis.Name = "Wis";
            this.Wis.Size = new System.Drawing.Size(75, 23);
            this.Wis.TabIndex = 2;
            this.Wis.Text = "Wis";
            this.Wis.UseVisualStyleBackColor = true;
            this.Wis.Click += new System.EventHandler(this.Wis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // frm04_Chronometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Wis);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtChrono);
            this.Controls.Add(this.label1);
            this.Name = "frm04_Chronometer";
            this.Text = "Chronometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChrono;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button Wis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}