namespace Kirjautumissivu
{
    partial class Etusivu
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnLisaaTuote = new System.Windows.Forms.Button();
            this.btnAsiakkaanLisays = new System.Windows.Forms.Button();
            this.btnLopeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(281, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Siirry tuotteen lisäyssivulle tästä";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(12, 141);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(164, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Siirry asiakkaan lisäyssivulle tästä";
            // 
            // btnLisaaTuote
            // 
            this.btnLisaaTuote.Location = new System.Drawing.Point(215, 31);
            this.btnLisaaTuote.Name = "btnLisaaTuote";
            this.btnLisaaTuote.Size = new System.Drawing.Size(10, 26);
            this.btnLisaaTuote.TabIndex = 1;
            this.btnLisaaTuote.Text = "Siirry";
            this.btnLisaaTuote.UseVisualStyleBackColor = true;
            // 
            // btnAsiakkaanLisays
            // 
            this.btnAsiakkaanLisays.Location = new System.Drawing.Point(215, 63);
            this.btnAsiakkaanLisays.Name = "btnAsiakkaanLisays";
            this.btnAsiakkaanLisays.Size = new System.Drawing.Size(10, 31);
            this.btnAsiakkaanLisays.TabIndex = 0;
            this.btnAsiakkaanLisays.Text = "Siirry";
            this.btnAsiakkaanLisays.UseVisualStyleBackColor = true;
            this.btnAsiakkaanLisays.Click += new System.EventHandler(this.btnAsiakkaanLisays_Click);
            // 
            // btnLopeta
            // 
            this.btnLopeta.Location = new System.Drawing.Point(171, 247);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(164, 73);
            this.btnLopeta.TabIndex = 6;
            this.btnLopeta.Text = "LOPETA OHJELMA";
            this.btnLopeta.UseVisualStyleBackColor = true;
       
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 374);
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLisaaTuote);
            this.Controls.Add(this.btnAsiakkaanLisays);
            this.Name = "Etusivu";
            this.Text = "Etusivu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnLisaaTuote;
        private System.Windows.Forms.Button btnAsiakkaanLisays;
        private System.Windows.Forms.Button btnLopeta;
    }
}