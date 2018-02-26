using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kirjautumissivu
{

    
    public partial class formTuotteenLisays : Form
    {
        string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
        public formTuotteenLisays()
        {
            InitializeComponent();
        }

        private void formTuotteenLisays_load(object sender, EventArgs e)
        {
            try
            {



                OleDbConnection con = new OleDbConnection(cs);

                OleDbCommand cmd = new OleDbCommand("Select * from Tuotteet ", con);
                // Avatan yhteys
                con.Open();
                // luodaan DataAdapter tietojen käsittelemiseksi 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                // luodaan lomakkeelle Datatable komonentti nimellä asiakas
                DataTable Tuotteet = new DataTable();

                // luetaan tiedot 
                da.Fill(Tuotteet);
                // Tuodaan tiedot DataGrid komponentiin
                grdTuote.DataSource = Tuotteet;
                //suljetaan tietokanta yhteys
                con.Close();
            }
            // mikäli käsittelyssä tapahtuu joku virhe, tulostetaan tieto virheestä näytölle
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLisaaTuote_Click(object sender, EventArgs e)
        {
            try
            {

                //luodaan uusi yhteys
                OleDbConnection con = new OleDbConnection(cs);
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = con;
                con.Open();
                // luodaan SQL komento, jonka avulla lisätään tiedot tietokantaan
                comm.CommandText = "Insert into Tuotteet (Tuotteen_nimi,Tuote_tyyppi,Tuotteen_Tiedot, Tuotteen_Valmistaja) VALUES ('" + txtTuotteenNimi.Text + "','" + txt_tuoteTyyppi.Text + "','" + txtTuotteenTiedot.Text + "','" + txtValmistaja.Text + "')";
                //suoritetaan SQL komento, joka lisää tiedot
                comm.ExecuteNonQuery();
                con.Close();
                btnPaivita.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPoistaTuote_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Haluatko varmasti poistaa tuotteen " + txtTuoteID.Text, "Tuotteen poistaminen", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {

            }

            else
            {

                try
                {

                    //luodaan uusi yhteys
                    OleDbConnection con = new OleDbConnection(cs);
                    OleDbCommand comm = new OleDbCommand();





                    comm.Connection = con;
                    con.Open();
                    // luodaan SQL komento, jonka avulla poistetaan
                    comm.CommandText = "Delete from  Tuotteet Where Tuote_ID=" + txtTuoteID.Text;
                    // suoritetaan SQL komento, joka poistaa tiedot
                    // määritellään muuttuja testi, jonka avulla tarkistetaan, että poistettava asiakas on olemassa
                    int testi = comm.ExecuteNonQuery();
                    con.Close();
                    btnPaivita.PerformClick();
                    if (testi == 0)
                    {
                        MessageBox.Show(" Tuotetta ei löydy");
                    }
                    else
                    {
                        MessageBox.Show(" Poistettu");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Anna tuotteen ID");
                }

            }
        }
        private void btnPaivita_Click(object sender, EventArgs e)
        {
            try
            {
               
                //luodaan uusi yhteys
                OleDbConnection con = new OleDbConnection(cs);
                // annetaan SQL komento joka hakee kaikki  Asiakas taulun tiedot ja järjestää ne asiakas numeronmukaan
                OleDbCommand cmd = new OleDbCommand("Select * from Tuotteet order by Tuote_ID ", con);
                // Avatan yhteys
                con.Open();
                // luodaan DataAdapter tietojen käsittelemiseksi 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                // luodaan lomakkeelle Datatable komonentti nimellä asiakas
                DataTable asiakas = new DataTable();
                // luetaan tiedot asiakas Data Table komponentiin
                da.Fill(asiakas);
                // Tuodaan tiedot DataGrid komponentiin
                grdTuote.DataSource = asiakas;
                //suljetaan tietokanta yhteys
                con.Close();
            }
            // mikäli käsittelyssä tapahtuu joku virhe, tulostetaan tieto virhestä näytölle
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
