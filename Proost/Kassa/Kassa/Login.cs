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
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.Login(TbGebruikersNaam.Text, tbWachtwoord.Text) == true){
                db.ingelogdeGebruikerNaam = TbGebruikersNaam.Text;
                db.ingelogdeGebruikerww = tbWachtwoord.Text; 
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
