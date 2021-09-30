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
    public partial class ListMag : Form
    {
        List<Magasin> lesMagasins = new List<Magasin>();
        Personnel user = new Personnel();

        public ListMag(List<Magasin> magasins, Personnel user)
        {
            this.lesMagasins = magasins;
            InitializeComponent();
            AfficherMag(lesMagasins);
            this.user = user;
            
        }
        private void AfficherMag(List<Magasin> lesMagasins)
        {
            foreach (Magasin item in lesMagasins)
            {
                listBox1.Items.Add(item.city + " " + item.nom);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (user.fonction == "Manager")
            {
                var HomeMan = new HomeMan(user);
                HomeMan.Closed += (s, args) => this.Close();
                HomeMan.Show();
            }
            else if (user.fonction == "Commercial")
            {
                var HomeCom = new HomeCom(user);
                HomeCom.Closed += (s, args) => this.Close();
                HomeCom.Show();
            }
        }

        private void ListMag_Load(object sender, EventArgs e)
        {

        }
    }
}