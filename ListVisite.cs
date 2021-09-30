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
    public partial class ListVisite : Form
    {
        List<Visite> lesVisites = new List<Visite>();
        Connection ConnectionDb = new Connection();
        Personnel user = new Personnel();

        public ListVisite(List<Visite> visites, Personnel user)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var HomeMan = new HomeMan(user);
            HomeMan.Closed += (s, args) => this.Close();
            HomeMan.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = "";
            int selected = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                string selecteditem = listBox1.SelectedItem.ToString();
                string[] tab = selecteditem.Split(" ");
                id = tab[0];
                ConnectionDb.DeleteItemVisite(id);
                listBox1.Items.RemoveAt(selected);
                lesVisites.RemoveAt(selected);
            }
        }
    }
}