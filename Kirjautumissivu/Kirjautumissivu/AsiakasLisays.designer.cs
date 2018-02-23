namespace Kirjautumissivu
{
    partial class formLisaaAsiakas
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
            this.gridAsiakas = new System.Windows.Forms.DataGridView();
            this.txtSukunimi = new System.Windows.Forms.TextBox();
            this.txtEtunimi = new System.Windows.Forms.TextBox();
            this.txtSahkoposti = new System.Windows.Forms.TextBox();
            this.txtPuhelin = new System.Windows.Forms.TextBox();
            this.txtKatuOsoite = new System.Windows.Forms.TextBox();
            this.txtPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txtPostiNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAsiakasnumero = new System.Windows.Forms.TextBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsiakas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAsiakas
            // 
            this.gridAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsiakas.Location = new System.Drawing.Point(31, 12);
            this.gridAsiakas.Name = "gridAsiakas";
            this.gridAsiakas.Size = new System.Drawing.Size(832, 347);
            this.gridAsiakas.TabIndex = 0;
            // 
            // txtSukunimi
            // 
            this.txtSukunimi.Location = new System.Drawing.Point(243, 404);
            this.txtSukunimi.Name = "txtSukunimi";
            this.txtSukunimi.Size = new System.Drawing.Size(100, 20);
            this.txtSukunimi.TabIndex = 2;
            // 
            // txtEtunimi
            // 
            this.txtEtunimi.Location = new System.Drawing.Point(31, 404);
            this.txtEtunimi.Name = "txtEtunimi";
            this.txtEtunimi.Size = new System.Drawing.Size(100, 20);
            this.txtEtunimi.TabIndex = 1;
            // 
            // txtSahkoposti
            // 
            this.txtSahkoposti.Location = new System.Drawing.Point(243, 455);
            this.txtSahkoposti.Name = "txtSahkoposti";
            this.txtSahkoposti.Size = new System.Drawing.Size(213, 20);
            this.txtSahkoposti.TabIndex = 4;
            // 
            // txtPuhelin
            // 
            this.txtPuhelin.Location = new System.Drawing.Point(31, 455);
            this.txtPuhelin.Name = "txtPuhelin";
            this.txtPuhelin.Size = new System.Drawing.Size(100, 20);
            this.txtPuhelin.TabIndex = 3;
            // 
            // txtKatuOsoite
            // 
            this.txtKatuOsoite.Location = new System.Drawing.Point(31, 515);
            this.txtKatuOsoite.Name = "txtKatuOsoite";
            this.txtKatuOsoite.Size = new System.Drawing.Size(100, 20);
            this.txtKatuOsoite.TabIndex = 5;
            // 
            // txtPostitoimipaikka
            // 
            this.txtPostitoimipaikka.Location = new System.Drawing.Point(243, 515);
            this.txtPostitoimipaikka.Name = "txtPostitoimipaikka";
            this.txtPostitoimipaikka.Size = new System.Drawing.Size(100, 20);
            this.txtPostitoimipaikka.TabIndex = 7;
            // 
            // txtPostiNro
            // 
            this.txtPostiNro.Location = new System.Drawing.Point(137, 515);
            this.txtPostiNro.Name = "txtPostiNro";
            this.txtPostiNro.Size = new System.Drawing.Size(100, 20);
            this.txtPostiNro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puhelin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sähköposti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Katuosoite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Postinumero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Postitoimipaikka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Asiakasnumero";
            // 
            // txtAsiakasnumero
            // 
            this.txtAsiakasnumero.Location = new System.Drawing.Point(727, 499);
            this.txtAsiakasnumero.Name = "txtAsiakasnumero";
            this.txtAsiakasnumero.Size = new System.Drawing.Size(100, 20);
            this.txtAsiakasnumero.TabIndex = 16;
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(353, 116);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(10, 10);
            this.btnPaivita.TabIndex = 17;
            this.btnPaivita.Text = "button1";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(31, 551);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(100, 23);
            this.btnLisaa.TabIndex = 18;
            this.btnLisaa.Text = "Lisää lainaaja";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(727, 534);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 23);
            this.btnPoista.TabIndex = 19;
            this.btnPoista.Text = "Poista lainaaja";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "Palaa Etusivulle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formLisaaAsiakas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.txtAsiakasnumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPostiNro);
            this.Controls.Add(this.txtPostitoimipaikka);
            this.Controls.Add(this.txtKatuOsoite);
            this.Controls.Add(this.txtPuhelin);
            this.Controls.Add(this.txtSahkoposti);
            this.Controls.Add(this.txtEtunimi);
            this.Controls.Add(this.txtSukunimi);
            this.Controls.Add(this.gridAsiakas);
            this.Controls.Add(this.btnPaivita);
            this.Name = "formLisaaAsiakas";
            this.Text = "FormLisaaAsiakas";
            this.Load += new System.EventHandler(this.formLisaaAsiakas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAsiakas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAsiakas;
        private System.Windows.Forms.TextBox txtSukunimi;
        private System.Windows.Forms.TextBox txtEtunimi;
        private System.Windows.Forms.TextBox txtSahkoposti;
        private System.Windows.Forms.TextBox txtPuhelin;
        private System.Windows.Forms.TextBox txtKatuOsoite;
        private System.Windows.Forms.TextBox txtPostitoimipaikka;
        private System.Windows.Forms.TextBox txtPostiNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAsiakasnumero;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button button2;
    }
}

