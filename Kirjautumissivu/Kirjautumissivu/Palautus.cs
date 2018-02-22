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



        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
