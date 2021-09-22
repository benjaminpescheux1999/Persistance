using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Persistance
{
    class Connection
    {

        public void TestLogin(string name, string password)
        {
            SqlConnection maConnexion = null;
            try
            {
                maConnexion = new SqlConnection(@"server=LAPTOP-PCDHAT6A\SQLEXPRESS;database=Persistance;integrated security=true");
                SqlCommand maCommande = new SqlCommand();
                maCommande.Connection = maConnexion;
                maCommande.CommandText = "SELECT * FROM Personnel where nomPers= '" + name + "' and passwordPers ='" + password + "'";
                maConnexion.Open();
                SqlDataReader monReader = maCommande.ExecuteReader();
               

            }
            finally
            {
                maConnexion.Close();
            }


        }

        public int Login(string name, string password)
        {
            int status = 0;
            try
            {
                String str = @"server=LAPTOP-PCDHAT6A\SQLEXPRESS;database=Persistance;integrated security=true";
                String query = "select * from Personnel where nomPers= '" + name + "' and passwordPers ='" + password + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    status = int.Parse(string.Format("{0}", dataReader["fonctionPers"]));
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return status;
        }
    }
}
