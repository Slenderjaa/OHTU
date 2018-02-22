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
            this.SuspendLayout();
            // 
            // btnLainaa
            // 
            this.btnLainaa.Location = new System.Drawing.Point(67, 233);
            this.btnLainaa.Name = "btnLainaa";
            this.btnLainaa.Size = new System.Drawing.Size(75, 23);
            this.btnLainaa.TabIndex = 0;
            this.btnLainaa.Text = "Lainaa";
            this.btnLainaa.UseVisualStyleBackColor = true;
            this.btnLainaa.Click += new System.EventHandler(this.btnLainaa_Click);
            // 
            // chkListTuotteet
            // 
            this.chkListTuotteet.FormattingEnabled = true;
            this.chkListTuotteet.Location = new System.Drawing.Point(67, 70);
            this.chkListTuotteet.Name = "chkListTuotteet";
            this.chkListTuotteet.Size = new System.Drawing.Size(120, 94);
            this.chkListTuotteet.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboKayttajat
            // 
            this.comboKayttajat.FormattingEnabled = true;
            this.comboKayttajat.Location = new System.Drawing.Point(288, 70);
            this.comboKayttajat.Name = "comboKayttajat";
            this.comboKayttajat.Size = new System.Drawing.Size(121, 21);
            this.comboKayttajat.TabIndex = 3;
            this.comboKayttajat.SelectedIndexChanged += new System.EventHandler(this.comboKayttajat_SelectedIndexChanged);
            // 
            // Lainaussivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 462);
            this.Controls.Add(this.comboKayttajat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chkListTuotteet);
            this.Controls.Add(this.btnLainaa);
            this.Name = "Lainaussivu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Lainaussivu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLainaa;
        private System.Windows.Forms.CheckedListBox chkListTuotteet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboKayttajat;
    }
}