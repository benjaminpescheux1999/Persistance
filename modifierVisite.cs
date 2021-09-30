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


        public modifierVisite(Personnel user, List<Magasin> lesMagasins)
        {
            InitializeComponent();
            this.user = user;

            foreach (Magasin m in lesMagasins)
            {
                comboBox1.Items.Add(m.id + " " + m.nom + " | " + m.city);
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
    }
}