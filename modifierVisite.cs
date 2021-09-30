using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistance
{
    public partial class modifierVisite : Form
    {

        Connection ConnectionDb = new Connection();
        Personnel user = new Personnel();
        List<Magasin> lesMagasins = new List<Magasin>();
        Visite visite = new Visite();

        public modifierVisite(Personnel user, List<Magasin> lesMagasins, Visite visite)
        {
            InitializeComponent();
            this.user = user;
            this.visite = visite;
            foreach (Magasin m in lesMagasins)
            {
                comboBox1.Items.Add(m.id + " " + m.nom + " | " + m.city);
            }

            dateTimePicker1.Value = DateTime.Parse(visite.datevisite);
            Magasin mag = ConnectionDb.RecupMagasisn(visite.magasin);

            comboBox1.Text = mag.id + " " + mag.nom + " | " + mag.city;
            if (visite.flag == "True")
            {
                checkBox1.Checked = true;
                string ici = "";
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var HomeCom = new HomeCom(user);
            HomeCom.Closed += (s, args) => this.Close();
            HomeCom.Show();
        }

        private void modifierVisite_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int etat;
            DateTime datevisite = dateTimePicker1.Value;
            if (checkBox1.Checked)
            {
                etat = 1;
            }
            else
            {
                etat = 0;
            }

            string magasin = comboBox1.Text;
            if (magasin != "")
            {
                string[] tab = magasin.Split(" ");

                ConnectionDb.modifierVisite(visite.idvisite,datevisite, etat, tab[0]);

                MessageBox.Show("Visite modifié");

                this.Hide();
                var HomeCom = new VisiteCommerical(ConnectionDb.AfficheVisite(),user);
                HomeCom.Closed += (s, args) => this.Close();
                HomeCom.Show();
            }
            else
            {
                MessageBox.Show("Renseigner tout les champs");
            }
        }
    }
}