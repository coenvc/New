using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace development
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            toolTip1.OwnerDraw = true;
            toolTip1.Draw)_
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void button1_MouseLeave(object sender, EventArgs e)
        {
          
        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
               
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
