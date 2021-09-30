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
    public partial class HomeCom : Form
    {
        Connection ConnectionDb = new Connection();
        Personnel user = new Personnel();

        public HomeCom(Personnel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeCom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Magasin> lesMagasins = ConnectionDb.AfficheMag();
            this.Hide();
            var ListMag = new ListMag(lesMagasins, user);
            ListMag.Closed += (s, args) => this.Close();
            ListMag.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Visite> lesVisites = ConnectionDb.AfficheVisite();
            this.Hide();
            var VisiteCommerical = new VisiteCommerical(lesVisites, user);
            VisiteCommerical.Closed += (s, args) => this.Close();
            VisiteCommerical.Show();

        }
    }
}