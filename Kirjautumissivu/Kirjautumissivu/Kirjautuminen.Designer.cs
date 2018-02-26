namespace Kirjautumissivu
{
    partial class Form1
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
            this.txtKayttaja = new System.Windows.Forms.TextBox();
            this.txtSalasana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKirjaudu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKayttaja
            // 
            this.txtKayttaja.Location = new System.Drawing.Point(6, 69);
            this.txtKayttaja.Name = "txtKayttaja";
            this.txtKayttaja.Size = new System.Drawing.Size(130, 20);
            this.txtKayttaja.TabIndex = 0;
            this.txtKayttaja.Text = "admin";
            // 
            // txtSalasana
            // 
            this.txtSalasana.Location = new System.Drawing.Point(142, 69);
            this.txtSalasana.Name = "txtSalasana";
            this.txtSalasana.PasswordChar = '*';
            this.txtSalasana.Size = new System.Drawing.Size(130, 20);
            this.txtSalasana.TabIndex = 1;
            this.txtSalasana.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Käyttäjätunnus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salasana";
            // 
            // btnKirjaudu
            // 
            this.btnKirjaudu.Location = new System.Drawing.Point(91, 124);
            this.btnKirjaudu.Name = "btnKirjaudu";
            this.btnKirjaudu.Size = new System.Drawing.Size(111, 40);
            this.btnKirjaudu.TabIndex = 4;
            this.btnKirjaudu.Text = "Kirjaudu";
            this.btnKirjaudu.UseVisualStyleBackColor = true;
            this.btnKirjaudu.Click += new System.EventHandler(this.btnKirjaudu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kirjautumissivu.Properties.Resources.asdasd;
            this.ClientSize = new System.Drawing.Size(308, 223);
            this.Controls.Add(this.btnKirjaudu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalasana);
            this.Controls.Add(this.txtKayttaja);
            this.Name = "Form1";
            this.Text = "Kirjautumissivu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKayttaja;
        private System.Windows.Forms.TextBox txtSalasana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKirjaudu;
    }
}

