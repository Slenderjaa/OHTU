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
    public partial class Lainaussivu : Form
    {

        void update()
        {

            chkListTuotteet.Items.Clear();
            string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\p119992\Source\Repos\OHTU\Kirjautumissivu\Kirjautumissivu\0\reservationsystem.mdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = con;
            con.Open();
            // luodaan SQL komento, jonka avulla lisätään tiedot tietokantaan
            comm.CommandText = "SELECT * FROM Tuotteet WHERE Tuotteen_Tila='Saatavilla';";
            //suoritetaan SQL komento, joka lisää tiedot
            OleDbDataReader reader = comm.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Ei löytynyt lainattavia tavaroita");
            }
            else
            {
                while (reader.Read())
                {
                    Tavarat item = new Tavarat();
                    item.Tuote_ID = (int)reader[0];
                    item.Tuotteen_nimi = (string)reader[1];
                    item.Tuotteen_tila = (string)reader[5];
                    chkListTuotteet.Items.Add(item);
                    chkListTuotteet.DisplayMember = "Tuotteen_nimi";
                }

            }
            con.Close();



            comboKayttajat.Items.Clear();
            comm.Connection = con;
            con.Open();
            // luodaan SQL komento, jonka avulla lisätään tiedot tietokantaan
            comm.CommandText = "SELECT * FROM Asiakas;";
            //suoritetaan SQL komento, joka lisää tiedot
             reader = comm.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Ei löytynyt asiakkaita");
            }
            else
            {
                while (reader.Read())
                {
                    User User = new User();
                    User.ID = (int)reader[0];
                    User.Username = (string)reader[1].ToString() + " " + (string)reader[2].ToString();
                    comboKayttajat.Items.Add(User);
                    
                    comboKayttajat.DisplayMember = "Username";
                }

            }
            con.Close();


        }
        public Lainaussivu()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(28);

            update();


            
        }

        private void btnLainaa_Click(object sender, EventArgs e)
        {
            foreach (Tavarat item in chkListTuotteet.CheckedItems)
            {
                try
                {
                    string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\p119992\Source\Repos\OHTU\Kirjautumissivu\Kirjautumissivu\0\reservationsystem.mdb";
                    //luodaan uusi yhteys
                    OleDbConnection con = new OleDbConnection(cs);
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = con;
                    OleDbCommand comm2 = new OleDbCommand();
                    comm2.Connection = con;
                    OleDbCommand comm3 = new OleDbCommand();
                    comm3.Connection = con;
                    
                    con.Open();
        
                    comm.CommandText = "Insert into Tilaus(Asiakas_ID) VALUES (@user_id);";
                    comm2.CommandText = " Insert into Lainausrivit(Tuote_ID, Lainaus_ID, Lainan_aloitus_pvm, Lainan_lopetus_pvm, Lainassa) values(@Tuote_ID, @@Identity, @Lainan_aloitus_pvm, @Lainan_lopetus_pvm, Yes);";
                    comm3.CommandText = "Update Tuotteet SET Tuotteen_tila = 'Lainassa' WHERE Tuote_ID =@Tuote_ID";
                    comm.Parameters.AddWithValue("@user_ID", comboKayttajat.SelectedItem);
                    comm2.Parameters.AddWithValue("@Tuote_ID", item.Tuote_ID);
                    comm3.Parameters.AddWithValue("@Tuote_ID", item.Tuote_ID);
                    comm2.Parameters.AddWithValue("@Lainan_aloitus_pvm", dateTimePicker1.Value.ToShortDateString());
                    comm2.Parameters.AddWithValue("@Lainan_lopetus_pvm", dateTimePicker1.Value.AddDays(14).ToShortDateString());
                  
                    comm.ExecuteNonQuery();
                    comm2.ExecuteNonQuery();
                    comm3.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                
                }
            update();
        }

        private void Lainaussivu_Load(object sender, EventArgs e)
        {

        }

        private void comboKayttajat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
