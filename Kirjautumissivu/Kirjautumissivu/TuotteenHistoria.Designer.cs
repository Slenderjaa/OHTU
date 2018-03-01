namespace Kirjautumissivu
{
    partial class TuotteenHistoria
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
            this.comboBoxTuote = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listTuotteenHistoria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxTuote
            // 
            this.comboBoxTuote.FormattingEnabled = true;
            this.comboBoxTuote.Location = new System.Drawing.Point(12, 55);
            this.comboBoxTuote.Name = "comboBoxTuote";
            this.comboBoxTuote.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTuote.TabIndex = 0;
            this.comboBoxTuote.SelectedIndexChanged += new System.EventHandler(this.comboBoxTuote_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tuotteen nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(222, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuotteen lainaushistoria";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listTuotteenHistoria
            // 
            this.listTuotteenHistoria.FormattingEnabled = true;
            this.listTuotteenHistoria.Location = new System.Drawing.Point(225, 55);
            this.listTuotteenHistoria.Name = "listTuotteenHistoria";
            this.listTuotteenHistoria.Size = new System.Drawing.Size(213, 277);
            this.listTuotteenHistoria.TabIndex = 3;
            // 
            // TuotteenHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.jeeeeeeeeeeee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 352);
            this.Controls.Add(this.listTuotteenHistoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTuote);
            this.DoubleBuffered = true;
            this.Name = "TuotteenHistoria";
            this.Text = "TuotteenHistoria";
            this.Load += new System.EventHandler(this.TuotteenHistoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listTuotteenHistoria;
    }
}