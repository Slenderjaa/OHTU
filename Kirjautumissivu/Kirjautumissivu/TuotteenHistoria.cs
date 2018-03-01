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
    public partial class TuotteenHistoria : Form
    {
        string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
        public TuotteenHistoria()
        {

            
            InitializeComponent();
            updateitems();
        }


        void updateitems()
        {
            string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand comm = new OleDbCommand();

            comboBoxTuote.Items.Clear();
            comm.Connection = con;
            con.Open();

            comm.CommandText = "SELECT * FROM Tuotteet;";

            OleDbDataReader reader = comm.ExecuteReader();


            if (!reader.HasRows)
            {
                MessageBox.Show("Ei löytynyt asiakkaita");
            }
            else
            {
                while (reader.Read())
                {
                    Tuote item = new Tuote();
                    item.ID = (int)reader[0];
                    item.itemnimi = (string)reader[1].ToString();
                    comboBoxTuote.Items.Add(item);

                    comboBoxTuote.DisplayMember = "itemnimi";
                }

            }
            con.Close();


        }

        void updateTuotelista()
            

        {


            listTuotteenHistoria.Items.Clear();
            string tuote = ((Tuote)comboBoxTuote.SelectedItem).itemnimi;

            string qq = "SELECT Asiakas.Etunimi,  Asiakas.Sukunimi, Tuotteet.Tuote_ID, Lainausrivit.Lainan_aloitus_pvm, Lainausrivit.Lainan_lopetus_pvm, Lainausrivit.Lainassa, Tuotteet.Tuotteen_nimi " +
             "FROM Asiakas, Tilaus, Tuotteet, Lainausrivit WHERE Lainausrivit.Tuote_ID =@Tuote_ID AND Tuotteet.Tuote_ID = Lainausrivit.Tuote_ID AND Lainausrivit.Lainaus_ID = Tilaus.Tilaus_ID AND Asiakas.Asiakas_ID = Tilaus.Asiakas_ID";

           


            using (OleDbConnection cnn = new OleDbConnection(cs))

            {
                cnn.Open();
                using (OleDbCommand cmd = new OleDbCommand(qq, cnn))
                {
                 
                    cmd.Parameters.AddWithValue("@Tuote_ID", ((Tuote)comboBoxTuote.SelectedItem).ID);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime dt = (DateTime)reader["Lainan_aloitus_pvm"];
                        DateTime td = (DateTime)reader["Lainan_lopetus_pvm"];


                        listTuotteenHistoria.Items.Add(reader["Etunimi"] + " "+ (reader[ "Sukunimi"] +"  " +  dt.ToShortDateString() + " - " + td.ToShortDateString()));


                    }
                    
                    
                }
            }
        }
        private void comboBoxTuote_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTuotelista();
            
        }

        private void TuotteenHistoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
