namespace Kirjautumissivu
{
    partial class AsiakkaanHistoriaSivu
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
            this.comboAsiakas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEntisetLainat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboAsiakas
            // 
            this.comboAsiakas.FormattingEnabled = true;
            this.comboAsiakas.Location = new System.Drawing.Point(12, 84);
            this.comboAsiakas.Name = "comboAsiakas";
            this.comboAsiakas.Size = new System.Drawing.Size(135, 21);
            this.comboAsiakas.TabIndex = 0;
            this.comboAsiakas.SelectedIndexChanged += new System.EventHandler(this.comboAsiakas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse asiakas";
            // 
            // listEntisetLainat
            // 
            this.listEntisetLainat.FormattingEnabled = true;
            this.listEntisetLainat.Location = new System.Drawing.Point(272, 84);
            this.listEntisetLainat.MultiColumn = true;
            this.listEntisetLainat.Name = "listEntisetLainat";
            this.listEntisetLainat.ScrollAlwaysVisible = true;
            this.listEntisetLainat.Size = new System.Drawing.Size(277, 264);
            this.listEntisetLainat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asiakkaan entiset lainat";
            // 
            // AsiakkaanHistoriaSivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listEntisetLainat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAsiakas);
            this.Name = "AsiakkaanHistoriaSivu";
            this.Text = "Asiakkaan historia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAsiakas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEntisetLainat;
        private System.Windows.Forms.Label label2;
    }
}