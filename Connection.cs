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
                maConnexion = new SqlConnection(@"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true");
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
        public List<Magasin> AfficheMag()
        {
            List<Magasin> lesMagasins = new List<Magasin>();
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select * from Magasin";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Magasin magasin = new Magasin(dataReader["idMag"].ToString(), dataReader["nomMag"].ToString(), dataReader["cityMag"].ToString());
                    lesMagasins.Add(magasin);
                    /*                    status = int.Parse(string.Format("{0}", dataReader["fonctionPers"]));
                    */
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return lesMagasins;
        }

        public List<Visite> AfficheVisite()
        {
            List<Visite> lesVisites = new List<Visite>();
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select idvisite, visite.datevisite, case flagvisite when 0 then 'à faire' when 1 then 'fait' end as flag , Nompers + ' ' + prenomPers as Commercial, nommag + ' ' + citymag as nommag from visite   inner join personnel on visite.idCommercial = personnel.idPers inner join magasin on visite.idmagasin = magasin.idmag";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Visite visite = new Visite(dataReader["idvisite"].ToString(), dataReader["datevisite"].ToString(), dataReader["flag"].ToString(), dataReader["Commercial"].ToString(), dataReader["nommag"].ToString());
                    lesVisites.Add(visite);
                    /*                    status = int.Parse(string.Format("{0}", dataReader["fonctionPers"]));
                    */
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return lesVisites;
        }
        public void DeleteItemVisite(string id)
        {
            /*            int idconvert = Convert.ToInt32(id);
            */
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "DELETE FROM Visite WHERE idVisite=" + id;
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                MessageBox.Show("Visite supprimé !!");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void ajouterVisite(DateTime datevisite, int etat, string magasin, Personnel user)
        {
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "insert into visite (datevisite,flagvisite,idmagasin,idcommercial) values ('" + datevisite.ToString("dd/M/yyyy") + "'," + etat + "," + magasin + "," + user.id + " ); ";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }


        public bool VerifSuppressionVisite(string id, Personnel user)
        {
            bool rep = false;
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select * from visite where idvisite = '" + id + "' and idcommercial = '" + user.id + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    rep = true;
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            return rep;
        }

        public Personnel Login(string name, string password)
        {
            Personnel user = new Personnel();
            
            try
            {
                String str = @"server=LAPTOP-TS39PMJE\SQLEXPRESS2017;database=Persistance;integrated security=true";
                String query = "select p1.idPers,p1.nomPers,p1.prenomPers,p1.passwordPers,case p1.fonctionpers when 1 then 'Manager' when 2 then 'Commercial' end as fonction,p2.nompers + ' ' + p2.prenompers as nomman from Personnel p1 left join personnel p2 on p1.idman = p2.idpers where p1.nomPers= '" + name + "' and p1.passwordPers ='" + password + "'";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                DataSet ds = new DataSet();
                // Lecture des résultats
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    user.id = dataReader["idPers"].ToString();
                    user.nom = dataReader["nomPers"].ToString();
                    user.prenom = dataReader["prenomPers"].ToString();
                    user.mdp = dataReader["passwordPers"].ToString();
                    user.fonction = dataReader["fonction"].ToString();
                    user.nomMan = dataReader["nomMan"].ToString();
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            return user;
        }
    }
}