namespace Kirjautumissivu
{
    partial class Lainaussivu
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
            this.btnLainaa = new System.Windows.Forms.Button();
            this.chkListTuotteet = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboKayttajat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLainaa
            // 
            this.btnLainaa.Location = new System.Drawing.Point(262, 227);
            this.btnLainaa.Name = "btnLainaa";
            this.btnLainaa.Size = new System.Drawing.Size(109, 51);
            this.btnLainaa.TabIndex = 0;
            this.btnLainaa.Text = "Lainaa";
            this.btnLainaa.UseVisualStyleBackColor = true;
            this.btnLainaa.Click += new System.EventHandler(this.btnLainaa_Click);
            // 
            // chkListTuotteet
            // 
            this.chkListTuotteet.CheckOnClick = true;
            this.chkListTuotteet.FormattingEnabled = true;
            this.chkListTuotteet.Location = new System.Drawing.Point(298, 32);
            this.chkListTuotteet.Name = "chkListTuotteet";
            this.chkListTuotteet.Size = new System.Drawing.Size(120, 94);
            this.chkListTuotteet.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboKayttajat
            // 
            this.comboKayttajat.FormattingEnabled = true;
            this.comboKayttajat.Location = new System.Drawing.Point(12, 48);
            this.comboKayttajat.Name = "comboKayttajat";
            this.comboKayttajat.Size = new System.Drawing.Size(121, 21);
            this.comboKayttajat.TabIndex = 3;
            this.comboKayttajat.SelectedIndexChanged += new System.EventHandler(this.comboKayttajat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valitse asiakas";
            // 
            // btnPalaa
            // 
            this.btnPalaa.Location = new System.Drawing.Point(397, 252);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(94, 26);
            this.btnPalaa.TabIndex = 5;
            this.btnPalaa.Text = "Palaa etusivulle";
            this.btnPalaa.UseVisualStyleBackColor = true;
            this.btnPalaa.Click += new System.EventHandler(this.btnPalaa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valitse päivämäärä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(314, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valitse tuote";
            // 
            // Lainaussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.jeeeeeeeeeeee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 290);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboKayttajat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chkListTuotteet);
            this.Controls.Add(this.btnLainaa);
            this.DoubleBuffered = true;
            this.Name = "Lainaussivu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Lainaussivu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLainaa;
        private System.Windows.Forms.CheckedListBox chkListTuotteet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboKayttajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPalaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}