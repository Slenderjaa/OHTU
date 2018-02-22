using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjautumissivu
{
    class User
    {
        public string Username { get; set; }
        public int ID { get; set; }


        public static User createuser(string username, string password)
        {
            try
            {

                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\0\reservationsystem.mdb"))
                {

                    connection.Open();

                    User User;
                    using (OleDbCommand UserLogin = connection.CreateCommand())
                    {
                        UserLogin.CommandType = CommandType.Text;
                        UserLogin.CommandText = "SELECT TOP 1 * FROM Asiakas WHERE Sahkoposti=@user AND Salasana=@password";
                        UserLogin.Parameters.AddWithValue("@user", username);
                        UserLogin.Parameters.AddWithValue("@password", password);



                        OleDbDataReader reader = UserLogin.ExecuteReader();

                        if (!reader.HasRows)
                        {
                            return null;
                        }


                        reader.Read();


                        User = new User();
                        User.ID =  (int)reader[0];
                        User.Username = (string)reader[1].ToString() + " " + (string)reader[2].ToString();
                    }
                    return User;
                }
            }
            catch (Exception)
            { }
            return null;
        }
    }
}
