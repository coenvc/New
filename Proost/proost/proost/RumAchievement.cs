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
    public partial class RumAchievement : Form
    {
        DbConnection database;
        public void SetDb(DbConnection database)
        {
            this.database = database;
        } 

        public RumAchievement()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTipRum5 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipRum10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipRum25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipRum50 = new System.Windows.Forms.ToolTip();
            ToolTipRum5.SetToolTip(btnRum5, "0/5 behaald");
            ToolTipRum10.SetToolTip(btnRum10, "0/10 behaald");
            ToolTipRum25.SetToolTip(btnRum25, "0/25 behaald");
            ToolTipRum50.SetToolTip(btnRum50, "0/50 behaald");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();  
            HoofdScherm.Show(); 
        }
    }
}
