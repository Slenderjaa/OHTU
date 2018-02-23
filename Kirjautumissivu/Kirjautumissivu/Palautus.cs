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
    public partial class Palautus : Form
    {
        public Palautus()
        {
            InitializeComponent();
            update();
        }
        void update()
        {

            chkListTuotteet.Items.Clear();
            string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = con;
            con.Open();
            // luodaan SQL komento, jonka avulla lisätään tiedot tietokantaan
            comm.CommandText = "SELECT * FROM Tuotteet WHERE Tuotteen_Tila='Lainassa';";
            //suoritetaan SQL komento, joka lisää tiedot
            OleDbDataReader reader = comm.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Palauttamattomia tavaroita ei löytynyt.");
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



        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Tavarat item in chkListTuotteet.CheckedItems)
            {
                try
                {
                    string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
                    //luodaan uusi yhteys
                    OleDbConnection con = new OleDbConnection(cs);
                    OleDbCommand comm = new OleDbCommand();
                    comm.Connection = con;
                    OleDbCommand comm2 = new OleDbCommand();
                    comm2.Connection = con;
                    OleDbCommand comm3 = new OleDbCommand();
                    comm3.Connection = con;

                    con.Open();

                    
                    comm2.CommandText = "update Lainausrivit set Lainassa=no where Tuote_ID =@Tuote_ID";
                    comm3.CommandText = "Update Tuotteet SET Tuotteen_tila = 'Saatavilla' WHERE Tuote_ID =@Tuote_ID";
                    comm2.Parameters.AddWithValue("@Tuote_ID", item.Tuote_ID);
                    comm3.Parameters.AddWithValue("@Tuote_ID", item.Tuote_ID);
                    

                  
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
    }
    }

