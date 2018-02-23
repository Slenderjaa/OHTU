
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumissivu
{
    public partial class Etusivu : Form
    {
        public Etusivu()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            formTuotteenLisays ftuote = new formTuotteenLisays();
            ftuote.ShowDialog();
        }

 
        private void btnAsiakkaanLisays_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void btnLopeta_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            System.Environment.Exit(0);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // this.Hide();

            formLisaaAsiakas fasiakas = new formLisaaAsiakas();
            fasiakas.ShowDialog();
         
        }

        private void linkLainaus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Lainaussivu laina = new Lainaussivu();
            laina.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kirja = new Form1();
            kirja.ShowDialog();
        }

        private void Etusivu_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Palautus pala = new Palautus();
            pala.ShowDialog();
            
        }
    }
}
