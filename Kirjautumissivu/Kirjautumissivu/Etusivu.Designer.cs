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
            this.btnLopeta = new System.Windows.Forms.Button();
            this.linkLainaus = new System.Windows.Forms.LinkLabel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(148, 115);
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
            this.linkLabel2.Location = new System.Drawing.Point(148, 85);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(164, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Siirry asiakkaan lisäyssivulle tästä";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnLopeta
            // 
            this.btnLopeta.Location = new System.Drawing.Point(12, 289);
            this.btnLopeta.Name = "btnLopeta";
            this.btnLopeta.Size = new System.Drawing.Size(164, 73);
            this.btnLopeta.TabIndex = 6;
            this.btnLopeta.Text = "LOPETA OHJELMA";
            this.btnLopeta.UseVisualStyleBackColor = true;
            this.btnLopeta.Click += new System.EventHandler(this.btnLopeta_Click);
            // 
            // linkLainaus
            // 
            this.linkLainaus.AutoSize = true;
            this.linkLainaus.Location = new System.Drawing.Point(148, 163);
            this.linkLainaus.Name = "linkLainaus";
            this.linkLainaus.Size = new System.Drawing.Size(120, 13);
            this.linkLainaus.TabIndex = 7;
            this.linkLainaus.TabStop = true;
            this.linkLainaus.Text = "Siirry lainaussivulle tästä";
            this.linkLainaus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLainaus_LinkClicked);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(323, 289);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(164, 73);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "KIRJAUDU ULOS";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 374);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.linkLainaus);
            this.Controls.Add(this.btnLopeta);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Etusivu";
            this.Text = "Etusivu";
            this.Load += new System.EventHandler(this.Etusivu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnLopeta;
        private System.Windows.Forms.LinkLabel linkLainaus;
        private System.Windows.Forms.Button btnLogOut;
    }
}