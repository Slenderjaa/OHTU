using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumissivu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)
        {

            if (txtKayttaja.Text == "admin" && txtSalasana.Text == "admin")
                //kovakoodataan käyttäjätunnus ja salasana
            {
                this.Hide();
                //Kun käyttäjätunnus ja salasana menevät oikein, ohjelma piilottaa kirjautumisruudun
                Etusivu etusivu = new Etusivu();
                etusivu.ShowDialog();
            }

            else
            {
                MessageBox.Show("Väärä käyttäjätunnus tai salasana");
                //varmistetaan jos käyttäjätunnus ja salasana eivät ole samat kuin koodissa, niin ohjelma ei päästä sisään
            }
        }
    }
}
    
