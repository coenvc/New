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
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBier_Click(object sender, EventArgs e)
        {
           BierAchievement BierScherm = new BierAchievement();
           this.Hide();
           BierScherm.ShowDialog();  
                      
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            WijnAchievement WijnScherm = new WijnAchievement();
          this.Hide();
           WijnScherm.ShowDialog(); 
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            TequilaAchievement TequilaScherm = new TequilaAchievement();
            this.Hide();
            TequilaScherm.ShowDialog();  

        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            WodkaAchievement WodkaScherm = new WodkaAchievement();
            this.Hide();
            WodkaScherm.ShowDialog(); 
        }

        private void btnRum_Click(object sender, EventArgs e)
        {
            RumAchievement RumScherm = new RumAchievement();
            this.Hide();
            RumScherm.ShowDialog();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTerug_Click_1(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();
            HoofdScherm.ShowDialog();
        }
    }
}
