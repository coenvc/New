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
    public partial class kassa : Form
    {
        Database maakVerbinding = new Database();

        public kassa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void BtnBier_Click(object sender, EventArgs e)
        {
            maakVerbinding.AddBier(Convert.ToInt32(NumAantal.Value), Convert.ToInt32(TbBarcode.Text));
            LbBestelling.Items.Add("Aantal Bier: " + Convert.ToString(NumAantal.Value) + "    " + "Barcode: " + TbBarcode.Text);
            
            
        }

        private void BtnWijn_Click(object sender, EventArgs e)
        {
            maakVerbinding.AddWijn(Convert.ToInt32(NumAantal.Value), Convert.ToInt32(TbBarcode.Text));
            LbBestelling.Items.Add("Aantal Wijn: " + Convert.ToString(NumAantal.Value) + "    " + "Barcode: " + TbBarcode.Text);
        }

        private void BtnRum_Click(object sender, EventArgs e)
        {
            maakVerbinding.AddRum(Convert.ToInt32(NumAantal.Value), Convert.ToInt32(TbBarcode.Text));
            LbBestelling.Items.Add("Aantal Rum: " + Convert.ToString(NumAantal.Value) + "    " + "Barcode: " + TbBarcode.Text);
        }

        private void BtnVodka_Click(object sender, EventArgs e)
        {
            maakVerbinding.AddWodka(Convert.ToInt32(NumAantal.Value), Convert.ToInt32(TbBarcode.Text));
            LbBestelling.Items.Add("Aantal Vodka: " + Convert.ToString(NumAantal.Value) + "    " + "Barcode: " + TbBarcode.Text);
        }

        private void BtnTequila_Click(object sender, EventArgs e)
        {
            maakVerbinding.AddTequila(Convert.ToInt32(NumAantal.Value), Convert.ToInt32(TbBarcode.Text));
            LbBestelling.Items.Add("Aantal Tequila: " + Convert.ToString(NumAantal.Value) + "    " + "Barcode: " + TbBarcode.Text);
        }

        private void BtnNieuwe_Click(object sender, EventArgs e)
        {
            TbBarcode.Text = "";
            LbBestelling.Items.Clear();
            NumAantal.Value = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Info erp = new Info();
            this.Hide();
            erp.Show(); 
        }
    }
}
