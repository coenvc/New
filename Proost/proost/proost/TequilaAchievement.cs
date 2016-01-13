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
    public partial class TequilaAchievement : Form
    {
        DbConnection database;
        public void SetDb(DbConnection database)
        {
            this.database = database;
        } 

        public TequilaAchievement()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTipTequila5 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipTequila10 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipTequila25 = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipTequila50 = new System.Windows.Forms.ToolTip();
            ToolTipTequila5.SetToolTip(btnBier5, "0/5 behaald");
            ToolTipTequila10.SetToolTip(btnBier10, "0/10 behaald");
            ToolTipTequila25.SetToolTip(btnBier25, "0/25 behaald");
            ToolTipTequila50.SetToolTip(btnBier50, "0/50 behaald");
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home HoofdScherm = new Home();
            this.Hide();
            HoofdScherm.Show();
        }
    }
}
