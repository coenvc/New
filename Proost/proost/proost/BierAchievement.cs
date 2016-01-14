using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace proost
{
    public partial class BierAchievement : Form
    {
        DbConnection database;
        
        public void SetDb(DbConnection database)
        {
            this.database = database;
            database.Achievement();
            database.ControleerAchievementBier(); 
             // ToolTipBier5.SetToolTip(btnBier5, database.aantalBier()); 
            if (database.B5Behaald == true)
            {
                btnBier5.Image = ((System.Drawing.Image)(Properties.Resources.Bier5_fw));  
            } 
            if(database.B10Behaald == true)
            {
                btnBier10.Image = ((System.Drawing.Image)(Properties.Resources.Bier10_fw));
            } 
            if(database.B25Behaald == true)
            {
                btnBier25.Image = ((System.Drawing.Image)(Properties.Resources.Bier25_fw));
            }
            if (database.B50Behaald == true)
            {
                btnBier50.Image = ((System.Drawing.Image)(Properties.Resources.Bier50_fw));
            }
        }
         
        public BierAchievement()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTipBier5 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipBier50 = new System.Windows.Forms.ToolTip();
                
         
            ToolTipBier10.SetToolTip(btnBier10, "0/10 behaald");
            ToolTipBier25.SetToolTip(btnBier25, "/25 behaald");
            ToolTipBier50.SetToolTip(btnBier50, "/50 behaald");
           
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
