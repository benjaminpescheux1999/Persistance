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
    public partial class AjouterVisite : Form
    {

        Connection ConnectionDb = new Connection();
        Personnel user = new Personnel();
        List<Magasin> lesMagasins = new List<Magasin>();

        public AjouterVisite(Personnel user, List<Magasin> lesMagasins)
        {
            InitializeComponent();
            this.user = user;

            foreach (Magasin m in lesMagasins)
            {
                comboBox1.Items.Add(m.id + " " + m.nom + " | " + m.city);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var HomeCom = new HomeCom(user);
            HomeCom.Closed += (s, args) => this.Close();
            HomeCom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

                ConnectionDb.ajouterVisite(datevisite, etat, tab[0], user);

                MessageBox.Show("Visite ajoutÃ©e");

                this.Hide();
                var HomeCom = new HomeCom(user);
                HomeCom.Closed += (s, args) => this.Close();
                HomeCom.Show();
            }
            else
            {
                MessageBox.Show("Renseigner tout les champs");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}