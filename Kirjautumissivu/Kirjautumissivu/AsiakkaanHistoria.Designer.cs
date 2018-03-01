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
            this.components = new System.ComponentModel.Container();
            this.comboAsiakas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listEntisetLainat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // comboAsiakas
            // 
            this.comboAsiakas.FormattingEnabled = true;
            this.comboAsiakas.Location = new System.Drawing.Point(12, 75);
            this.comboAsiakas.Name = "comboAsiakas";
            this.comboAsiakas.Size = new System.Drawing.Size(135, 21);
            this.comboAsiakas.TabIndex = 0;
            this.comboAsiakas.SelectedIndexChanged += new System.EventHandler(this.comboAsiakas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse asiakas";
            // 
            // listEntisetLainat
            // 
            this.listEntisetLainat.FormattingEnabled = true;
            this.listEntisetLainat.Location = new System.Drawing.Point(272, 75);
            this.listEntisetLainat.MultiColumn = true;
            this.listEntisetLainat.Name = "listEntisetLainat";
            this.listEntisetLainat.ScrollAlwaysVisible = true;
            this.listEntisetLainat.Size = new System.Drawing.Size(277, 264);
            this.listEntisetLainat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(269, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asiakkaan lainaushistoria";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AsiakkaanHistoriaSivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.jeeeeeeeeeeee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listEntisetLainat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAsiakas);
            this.DoubleBuffered = true;
            this.Name = "AsiakkaanHistoriaSivu";
            this.Text = "Asiakkaan historia";
            this.Load += new System.EventHandler(this.AsiakkaanHistoriaSivu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAsiakas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEntisetLainat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}