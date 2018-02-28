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
    public partial class AsiakkaanHistoriaSivu : Form
    {

        string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
       

        public AsiakkaanHistoriaSivu()
        {
            InitializeComponent();
            updateusers();
        }



        void updateusers()
        {
            string cs = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\0\reservationsystem.mdb";
            OleDbConnection con = new OleDbConnection(cs);
            OleDbCommand comm = new OleDbCommand();

            comboAsiakas.Items.Clear();
            comm.Connection = con;
            con.Open();

            comm.CommandText = "SELECT * FROM Asiakas;";

            OleDbDataReader reader = comm.ExecuteReader();


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
                    comboAsiakas.Items.Add(User);

                    comboAsiakas.DisplayMember = "Username";
                }

            }
            con.Close();


        }







        private void btnLainaushistoria_Click(object sender, EventArgs e)
        {

        }

        private void comboAsiakas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nimi = ((User)comboAsiakas.SelectedItem).Username;
            string[] nimet;
            nimet = nimi.Split(' ');

            string etunimi = nimet[0];
            string sukunimi = nimet[1];


            string q = "SELECT Asiakas.Etunimi, Asiakas.Sukunimi, Lainausrivit.Lainan_aloitus_pvm, Lainausrivit.Lainan_lopetus_pvm, Lainausrivit.Lainassa, Tuotteet.Tuotteen_nimi " +
             "FROM(Asiakas INNER JOIN Tilaus ON Asiakas.Asiakas_ID = Tilaus.Asiakas_ID) INNER JOIN (Tuotteet INNER JOIN Lainausrivit ON Tuotteet.Tuote_ID = Lainausrivit.Tuote_ID) ON Tilaus.Tilaus_ID = Lainausrivit.Lainaus_ID "+
             "WHERE Asiakas.Etunimi =@Etunimi AND Asiakas.Sukunimi =@Sukunimi;";

            using (OleDbConnection cnn = new OleDbConnection(cs))

            {
                cnn.Open();
                using (OleDbCommand cmd = new OleDbCommand(q, cnn))
                {
                    cmd.Parameters.AddWithValue("@Etunimi", etunimi);
                    cmd.Parameters.AddWithValue("@Sukunimi", sukunimi);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime dt = (DateTime)reader["Lainan_aloitus_pvm"];
                        DateTime td = (DateTime)reader["Lainan_lopetus_pvm"];


                        listEntisetLainat.Items.Add(reader["Tuotteen_nimi"]+"  "+dt.ToShortDateString()+" - "+td.ToShortDateString());


                    }
                }
            }

           

        }
    }
}
