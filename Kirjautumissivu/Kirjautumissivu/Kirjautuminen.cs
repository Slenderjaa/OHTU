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
            User user = User.createuser(txtKayttaja.Text, txtSalasana.Text);
            if (user != null)
            {
                MessageBox.Show("kirjauduit sisään");

            }
            {
            //
                this.Hide();
         


                Etusivu etusivu = new Etusivu();
                etusivu.ShowDialog();


            }
        }
   
             
                    
                
            }
        }
    
