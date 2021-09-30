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
    public partial class Login : Form
    {
        Connection ConnectionDb = new Connection();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personnel user = ConnectionDb.Login(NamePers.Text, Password.Text);

            if (user.fonction == "Manager")
            {
                this.Hide();
                var HomeMan = new HomeMan(user);
                HomeMan.Closed += (s, args) => this.Close();
                HomeMan.Show();
            }
            else if (user.fonction == "Commercial")
            {
                this.Hide();
                var HomeCom = new HomeCom(user);
                HomeCom.Closed += (s, args) => this.Close();
                HomeCom.Show();
            }
            else
            {
                MessageBox.Show("Identifiants incorrect");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}