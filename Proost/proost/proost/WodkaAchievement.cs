﻿using System;
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
        DbConnection database;
        public void SetDb(DbConnection database)
        {
            this.database = database;
            database.Achievement();
            database.ControleerAchievementWodka();
            if (database.WO5Behaald == true)
            {
                btnWodka5.Image = ((System.Drawing.Image)(Properties.Resources.Vodka5_fw));

            }
            if (database.WO10Behaald == true)
            {

                btnWodka10.Image = ((System.Drawing.Image)(Properties.Resources.Vodka10_fw));

            }
            if (database.WO25Behaald == true)
            {

                btnWodka25.Image = ((System.Drawing.Image)(Properties.Resources.Vodka25_fw));
            }
            if (database.WO50Behaald == true)
            {

                btnWodka50.Image = ((System.Drawing.Image)(Properties.Resources.Vodka50_fw));
            }
        }
     

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
