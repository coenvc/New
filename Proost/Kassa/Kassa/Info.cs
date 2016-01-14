using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{ 
   
    public partial class Info : Form
    {
       
        Database db; 
        public Info()
        {
            InitializeComponent();
            
        }

        public void SetDb(Database db)
        {
            this.db = db;
        }

        private void drankChart_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.datum1 = dtp1.Value.ToString();
            db.datum2 = dtp1.Value.ToString();
            drankChart.Series["Aantal"].Points.AddXY("Bier", db.GetBier());
            drankChart.Series["Aantal"].Points.AddXY("Wijn", db.GetWijn());
            drankChart.Series["Aantal"].Points.AddXY("Wodka", db.GetWodka());
            drankChart.Series["Aantal"].Points.AddXY("Tequila", db.GetTequila());
            drankChart.Series["Aantal"].Points.AddXY("Rum", db.GetRum());
            lblTotaalAantal.Text = Convert.ToString(db.GetBier() *2.2 + db.GetWijn()*2.40 + db.GetWodka()*3 + db.GetTequila() *5+ db.GetRum() *4);
            lblAantalBier.Text = Convert.ToString(db.GetBier() * 2.2);
            lblAantalWijn.Text = Convert.ToString(db.GetWijn() * 2.40);
            lblAantalTequila.Text = Convert.ToString(db.GetTequila() * 3);
            lblAantalWodka.Text = Convert.ToString(db.GetWodka() * 5);
            lblAantalRum.Text = Convert.ToString(db.GetRum() * 4);
            progressBar1.Increment(Convert.ToInt32(db.GetBier() * 2.20 + db.GetWijn() * 2.40 + db.GetWodka() * 3.00 + db.GetTequila() * 5 + db.GetRum() * 4)); 

        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            kassa kassaScherm = new kassa(); 
            this.Close();
            kassaScherm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
