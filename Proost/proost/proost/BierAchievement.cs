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
    public partial class BierAchievement : Form
    {
        DbConnection database = new DbConnection();  
        
               
            public BierAchievement()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTipBier5 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier50 = new System.Windows.Forms.ToolTip();
          //  ToolTipBier5.SetToolTip(btnBier5, database.aantalBier());
            ToolTipBier10.SetToolTip(btnBier10, "0/10 behaald");
            ToolTipBier25.SetToolTip(btnBier25, "0/25 behaald");
            ToolTipBier50.SetToolTip(btnBier50, "0/50 behaald");
            database.Select();
        }
                
        private void btnBier10_Click(object sender, EventArgs e)
        {
        
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();
            HoofdScherm.Show(); 
        }
    }
}
