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


        public int Login(string name, string password)
        {
            int status = 0;
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
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

        public List<Magasin> getMagasin()
        {
            List <Magasin> lesMagasins= new List<Magasin>();

            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select * from Magasin ";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lesMagasins.Add(new Magasin(dataReader["idMag"].ToString(), dataReader["nomMag"].ToString(), dataReader["cityMag"].ToString()));
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return lesMagasins;
        }

        public List<Visite> getVisite()
        {
            List<Magasin> lesMagasins = new List<Magasin>();

            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select * from Magasin ";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lesMagasins.Add(new Magasin(dataReader["idMag"].ToString(), dataReader["nomMag"].ToString(), dataReader["cityMag"].ToString()));
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return null;
        }
    }
}
