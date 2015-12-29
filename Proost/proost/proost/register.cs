using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proost
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        { 
            DbConnection database = new DbConnection();                    
                database.AddUser(tbWachtwoord.Text, tbGebruikersnaam.Text, Convert.ToInt32(tbBarcode.Text));
            
            if (MessageBox.Show("Uw account is nu aangemaakt", "Naar login", MessageBoxButtons.OK) == DialogResult.OK)
            {
                Login loginScherm = new Login();
                this.Hide();
                loginScherm.Show();
 }

        }
    }
}
