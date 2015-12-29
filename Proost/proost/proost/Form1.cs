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
    public partial class Form1 : Form
    {
        DbConnection database = new DbConnection();
        public Form1()
        {
            InitializeComponent();
            database.Select(); 
            listBox1.DataSource = database.Select(); 
        }
    }
}
