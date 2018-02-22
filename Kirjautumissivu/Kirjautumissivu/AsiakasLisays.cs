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
    public partial class formLisaaAsiakas : Form
    {
        string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\p119997\Source\Repos\OHTU\Kirjautumissivu\Kirjautumissivu\0\reservationsystem.mdb";
        public formLisaaAsiakas()
        {
            InitializeComponent();
        }

        private void FormLisaaAsiakas(object sender, EventArgs e)
        {


            {
                try
                {
                    // Etsii tietokannan taulusta Asiakas kaikki tiedot ja tulostaa ne datagrid komponentiin
                    // määritellään string muuttuja jonkia avulla luodaan oleDb yhteys tilaus tietokantaan 
                    // HUOM !! kinteä tietokannan osoite

                    //luodaan uusi yhteys
                    OleDbConnection con = new OleDbConnection(cs);
                    // annetaan SQL komento joka hakee kaikki  Asiakas taulun tiedot ja järjestää ne asiakas numeronmukaan
                    OleDbCommand cmd = new OleDbCommand("Select * from Asiakas order by Asiakas_ID ", con);
                    // Avatan yhteys
                    con.Open();
                    // luodaan DataAdapter tietojen käsittelemiseksi 
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    // luodaan lomakkeelle Datatable komonentti nimellä asiakas
                    DataTable asiakas = new DataTable();
                    // luetaan tiedot asiakas Data Table komponentiin
                    da.Fill(asiakas);
                    // Tuodaan tiedot DataGrid komponentiin
                    gridAsiakas.DataSource = asiakas;
                    //suljetaan tietokanta yhteys
                    con.Close();
                }
                // mikäli käsittelyssä tapahtuu joku virhe, tulostetaan tieto virhestä näytölle
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {



                OleDbConnection con = new OleDbConnection(cs);

                OleDbCommand cmd = new OleDbCommand("Select * from Asiakas ", con);
                // Avatan yhteys
                con.Open();
                // luodaan DataAdapter tietojen käsittelemiseksi 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                // luodaan lomakkeelle Datatable komonentti nimellä asiakas
                DataTable asiakas = new DataTable();

                // luetaan tiedot 
                da.Fill(asiakas);
                // Tuodaan tiedot DataGrid komponentiin
               gridAsiakas.DataSource = asiakas;
                //suljetaan tietokanta yhteys
                con.Close();
            }
            // mikäli käsittelyssä tapahtuu joku virhe, tulostetaan tieto virheestä näytölle
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            try
            {

                //luodaan uusi yhteys
                OleDbConnection con = new OleDbConnection(cs);
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = con;
                con.Open();
                // luodaan SQL komento, jonka avulla lisätään tiedot tietokantaan
                comm.CommandText = "Insert into Asiakas (Etunimi,Sukunimi,PuhNro,Osoite,PostiNro,Postitoimipaikka, sahkoposti) VALUES ('" + txtEtunimi.Text + "','" + txtSukunimi.Text + "','" + txtPuhelin.Text + "','" + txtKatuOsoite.Text + "','" + txtPostiNro.Text + "','" + txtPostitoimipaikka.Text + "','" + txtSahkoposti.Text + "')";
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

        private void btnPoista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haluatko varmasti poistaa asiakkaan " + txtAsiakasnumero.Text, "Asiakkaan poistaminen", MessageBoxButtons.YesNo);



            try
            {

                //luodaan uusi yhteys
                OleDbConnection con = new OleDbConnection(cs);
                OleDbCommand comm = new OleDbCommand();





                comm.Connection = con;
                con.Open();
                // luodaan SQL komento, jonka avulla poistetaan
                comm.CommandText = "Delete from  Asiakas Where Asiakas_ID=" + txtAsiakasnumero.Text;
                // suoritetaan SQL komento, joka poistaa tiedot
                // määritellään muuttuja testi, jonka avulla tarkistetaan, että poistettava asiakas on olemassa
                int testi = comm.ExecuteNonQuery();
                con.Close();
                btnPaivita.PerformClick();
                if (testi == 0)
                {
                    MessageBox.Show(" Asiakasta ei löydy");
                }
                else
                {
                    MessageBox.Show(" Poistettu");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Anna asiakasnumeo");
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            try
            {
                // Etsii tietokannan taulusta Asiakas kaikki tiedot ja tulostaa ne datagrid komponentiin
                // määritellään string muuttuja jonkia avulla luodaan oleDb yhteys tilaus tietokantaan 
                // HUOM !! kinteä tietokannan osoite

                //luodaan uusi yhteys
                OleDbConnection con = new OleDbConnection(cs);
                // annetaan SQL komento joka hakee kaikki  Asiakas taulun tiedot ja järjestää ne asiakas numeronmukaan
                OleDbCommand cmd = new OleDbCommand("Select * from Asiakas order by Asiakas_ID ", con);
                // Avatan yhteys
                con.Open();
                // luodaan DataAdapter tietojen käsittelemiseksi 
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                // luodaan lomakkeelle Datatable komonentti nimellä asiakas
                DataTable asiakas = new DataTable();
                // luetaan tiedot asiakas Data Table komponentiin
                da.Fill(asiakas);
                // Tuodaan tiedot DataGrid komponentiin
                gridAsiakas.DataSource = asiakas;
                //suljetaan tietokanta yhteys
                con.Close();
            }
            // mikäli käsittelyssä tapahtuu joku virhe, tulostetaan tieto virhestä näytölle
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formLisaaAsiakas_Load(object sender, EventArgs e)
        {

        }
    }
}
