namespace Kirjautumissivu
{
    partial class formTuotteenLisays
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
            this.grdTuote = new System.Windows.Forms.DataGridView();
            this.txtTuotteenNimi = new System.Windows.Forms.TextBox();
            this.txt_tuoteTyyppi = new System.Windows.Forms.TextBox();
            this.txtValmistaja = new System.Windows.Forms.TextBox();
            this.txtTuotteenTiedot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLisaaTuote = new System.Windows.Forms.Button();
            this.btnPoistaTuote = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.txtTuoteID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTuote)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTuote
            // 
            this.grdTuote.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grdTuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTuote.Location = new System.Drawing.Point(12, 12);
            this.grdTuote.Name = "grdTuote";
            this.grdTuote.Size = new System.Drawing.Size(757, 278);
            this.grdTuote.TabIndex = 0;
            // 
            // txtTuotteenNimi
            // 
            this.txtTuotteenNimi.Location = new System.Drawing.Point(76, 329);
            this.txtTuotteenNimi.Name = "txtTuotteenNimi";
            this.txtTuotteenNimi.Size = new System.Drawing.Size(100, 20);
            this.txtTuotteenNimi.TabIndex = 1;
            // 
            // txt_tuoteTyyppi
            // 
            this.txt_tuoteTyyppi.Location = new System.Drawing.Point(260, 329);
            this.txt_tuoteTyyppi.Name = "txt_tuoteTyyppi";
            this.txt_tuoteTyyppi.Size = new System.Drawing.Size(100, 20);
            this.txt_tuoteTyyppi.TabIndex = 2;
            // 
            // txtValmistaja
            // 
            this.txtValmistaja.Location = new System.Drawing.Point(76, 432);
            this.txtValmistaja.Name = "txtValmistaja";
            this.txtValmistaja.Size = new System.Drawing.Size(100, 20);
            this.txtValmistaja.TabIndex = 3;
            // 
            // txtTuotteenTiedot
            // 
            this.txtTuotteenTiedot.Location = new System.Drawing.Point(260, 432);
            this.txtTuotteenTiedot.Multiline = true;
            this.txtTuotteenTiedot.Name = "txtTuotteenTiedot";
            this.txtTuotteenTiedot.Size = new System.Drawing.Size(203, 101);
            this.txtTuotteenTiedot.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tuotteen nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tuotteen tyyppi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valmistaja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tuotteen tiedot";
            // 
            // btnLisaaTuote
            // 
            this.btnLisaaTuote.Location = new System.Drawing.Point(101, 498);
            this.btnLisaaTuote.Name = "btnLisaaTuote";
            this.btnLisaaTuote.Size = new System.Drawing.Size(75, 23);
            this.btnLisaaTuote.TabIndex = 9;
            this.btnLisaaTuote.Text = "Lisää tuote";
            this.btnLisaaTuote.UseVisualStyleBackColor = true;
            this.btnLisaaTuote.Click += new System.EventHandler(this.btnLisaaTuote_Click);
            // 
            // btnPoistaTuote
            // 
            this.btnPoistaTuote.Location = new System.Drawing.Point(586, 455);
            this.btnPoistaTuote.Name = "btnPoistaTuote";
            this.btnPoistaTuote.Size = new System.Drawing.Size(75, 23);
            this.btnPoistaTuote.TabIndex = 10;
            this.btnPoistaTuote.Text = "Poista tuote";
            this.btnPoistaTuote.UseVisualStyleBackColor = true;
            this.btnPoistaTuote.Click += new System.EventHandler(this.btnPoistaTuote_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(417, 176);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(10, 10);
            this.btnPaivita.TabIndex = 11;
            this.btnPaivita.Text = "button1";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // txtTuoteID
            // 
            this.txtTuoteID.Location = new System.Drawing.Point(586, 429);
            this.txtTuoteID.Name = "txtTuoteID";
            this.txtTuoteID.Size = new System.Drawing.Size(100, 20);
            this.txtTuoteID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tuotteen ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Palaa etusivulle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formTuotteenLisays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.asdasd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTuoteID);
            this.Controls.Add(this.grdTuote);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.btnPoistaTuote);
            this.Controls.Add(this.btnLisaaTuote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTuotteenTiedot);
            this.Controls.Add(this.txtValmistaja);
            this.Controls.Add(this.txt_tuoteTyyppi);
            this.Controls.Add(this.txtTuotteenNimi);
            this.Name = "formTuotteenLisays";
            this.Text = "Tuotesivu";
            this.Load += new System.EventHandler(this.formTuotteenLisays_load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTuote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTuote;
        private System.Windows.Forms.TextBox txtTuotteenNimi;
        private System.Windows.Forms.TextBox txt_tuoteTyyppi;
        private System.Windows.Forms.TextBox txtValmistaja;
        private System.Windows.Forms.TextBox txtTuotteenTiedot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLisaaTuote;
        private System.Windows.Forms.Button btnPoistaTuote;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.TextBox txtTuoteID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

