using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*login podaci su zajednicki za sve zaposlene,
             prijava sluzi samo da zastiti koriscenje programa 
            od strane nezaposlenih lica*/
            string username = "123"; 
            string password = "123";
            if(textBoxUsername.Text==username && textBoxPassword.Text == password)
            {
                this.Hide();
                var m = new Meni();
                m.Closed += (s, args) => this.Close();
                m.Show();
            }
            else
            {
                MessageBox.Show("Pogresni podaci!");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
