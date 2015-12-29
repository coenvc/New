using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;

namespace proost
{
    public partial class Login : Form
    {
        DbConnection database = new DbConnection();

        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(database.Login(tbGebruikersnaam.Text, tbWachtwoord.Text) == true)
            {
                 
                database.naamGebruiker = tbGebruikersnaam.Text;
                database.wwGebruiker = tbWachtwoord.Text;
                Home hoofdpagina = new Home(); 
                this.Hide();
                hoofdpagina.Show();

            }
            

            else
            {
                MessageBox.Show(database.inlogStatus);
            }
            
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register RegistratieScherm = new register();
            this.Hide();
            RegistratieScherm.Show();

        }

        private void linkLabel1_LinkClicked_3(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register RegistratieScherm = new register();
            this.Hide();
            RegistratieScherm.Show();
        }
    }
}