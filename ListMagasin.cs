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
    public partial class ListMagasin : Form
    {
        Connection ConnectionDb = new Connection();
        List<Magasin> lesMagasins = new List<Magasin>();
        public ListMagasin()
        {
            InitializeComponent();
            lesMagasins = ConnectionDb.getMagasin();

            foreach (Magasin mag in lesMagasins)
            {
                listBox1.Items.Add(mag.id + " | " + mag.nom + " " + mag.city);

            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
