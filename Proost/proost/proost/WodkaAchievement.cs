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
    public partial class WodkaAchievement : Form
    {
        public WodkaAchievement()
        {
             InitializeComponent(); 
            System.Windows.Forms.ToolTip ToolTipWodka5  = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWodka10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWodka25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipWodka50 = new System.Windows.Forms.ToolTip();
            ToolTipWodka5.SetToolTip(btnWodka5, "0/5 behaald");
            ToolTipWodka10.SetToolTip(btnWodka10, "0/10 behaald");
            ToolTipWodka25.SetToolTip(btnWodka25, "0/25 behaald");
            ToolTipWodka50.SetToolTip(btnWodka50, "0/50 behaald");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();
            HoofdScherm.Show(); 
        }
    }
}
