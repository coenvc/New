using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class Login : Form
    {
        Database db = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            db.ingelogdeGebruikerNaam = TbGebruikersNaam.Text;
            db.ingelogdeGebruikerww = tbWachtwoord.Text;
            if (db.Login(TbGebruikersNaam.Text, tbWachtwoord.Text) == true){
                kassa kassaScherm = new kassa();
                this.Hide();
                kassaScherm.Show();
            }
            else
            {
                MessageBox.Show("Opgegeven gebruikersnaam en/of wachtwoord zijn onjuist");
            } 
            
        }
    }
}
