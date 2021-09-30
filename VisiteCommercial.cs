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
    public partial class VisiteCommerical : Form
    {
        List<Visite> lesVisites = new List<Visite>();
        Connection ConnectionDb = new Connection();
        Personnel user = new Personnel();

        public VisiteCommerical(List<Visite> visites, Personnel user)
        {
            this.lesVisites = visites;
            InitializeComponent();
            AfficherVisites(lesVisites);
            this.user = user;
        }

        private void AfficherVisites(List<Visite> lesVisites)
        {
            foreach (Visite item in lesVisites)
            {
                listBox1.Items.Add(item.idvisite + " Date : " + item.datevisite + " Status :  " + item.flag + "  Commercial :  " + item.commercial + "   Magasin : " + item.magasin);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            label1.Visible = true;
            AfficherVisites(lesVisites);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var HomeCom = new HomeCom(user);
            HomeCom.Closed += (s, args) => this.Close();
            HomeCom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {




            int selected = listBox1.SelectedIndex;
            try
            {
                string txt = listBox1.SelectedItem.ToString();

                String[] tab = txt.Split(" ");


                if (ConnectionDb.VerifSuppressionVisite(tab[0], user))
                {
                    if (listBox1.SelectedIndex != -1)
                    {
                        string selecteditem = listBox1.SelectedItem.ToString();
                        string[] tab2 = selecteditem.Split(" ");
                        string id = tab2[0];
                        ConnectionDb.DeleteItemVisite(id);
                        listBox1.Items.RemoveAt(selected);
                        lesVisites.RemoveAt(selected);
                    }
                }
                else
                {
                    MessageBox.Show("Vous ne pouvez supprimer que vos visites");
                }
            }
            catch
            {
                MessageBox.Show("Selectionner une visite");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AjouterVisite = new AjouterVisite(user, ConnectionDb.AfficheMag());
            AjouterVisite.Closed += (s, args) => this.Close();
            AjouterVisite.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var modifierVisite = new modifierVisite(user, ConnectionDb.AfficheMag());
            modifierVisite.Closed += (s, args) => this.Close();
            modifierVisite.Show();
        }

        private void VisiteCommerical_Load(object sender, EventArgs e)
        {

        }
    }
}