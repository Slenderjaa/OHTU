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
            listTuotteenHistoria.Items.Clear();


            string q = "SELECT Tuotteet.Tuote_ID, Lainausrivit.Lainan_aloitus_pvm, Lainausrivit.Lainan_lopetus_pvm, Lainausrivit.Lainassa, Tuotteet.Tuotteen_nimi " +
            "FROM(Asiakas INNER JOIN Tilaus ON Asiakas.Asiakas_ID = Tilaus.Asiakas_ID) INNER JOIN (Tuotteet INNER JOIN Lainausrivit ON Tuotteet.Tuote_ID = Lainausrivit.Tuote_ID) ON Tilaus.Tilaus_ID = Lainausrivit.Lainaus_ID ";
            
            using (OleDbConnection cnn = new OleDbConnection(cs))

            {
                cnn.Open();
                using (OleDbCommand cmd = new OleDbCommand(q, cnn))
                {

                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime dt = (DateTime)reader["Lainan_aloitus_pvm"];
                        DateTime td = (DateTime)reader["Lainan_lopetus_pvm"];


                        listTuotteenHistoria.Items.Add(reader["Tuotteen_nimi"] + "  " + dt.ToShortDateString() + " - " + td.ToShortDateString());
                    }
                }
            }

        }

        private void comboBoxTuote_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
               

            }
        }

        private void TuotteenHistoria_Load(object sender, EventArgs e)
        {

        }
    }
}
