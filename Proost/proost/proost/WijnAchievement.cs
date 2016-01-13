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
    public partial class WijnAchievement : Form
    {
        DbConnection database; 
        public void SetDb(DbConnection database)
        {
            this.database = database;
        }
        public WijnAchievement()
        { 
           
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTipWijn5 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWijn10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWijn25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWijn50 = new System.Windows.Forms.ToolTip();
            ToolTipWijn5.SetToolTip(btnWijn5, "0/5 behaald");
            ToolTipWijn10.SetToolTip(btnWijn10, "0/10 behaald");
            ToolTipWijn25.SetToolTip(btnWijn25, "0/25 behaald");
            ToolTipWijn50.SetToolTip(btnWijn50, "0/50 behaald");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();
            HoofdScherm.Show(); 
        }
    }
}
