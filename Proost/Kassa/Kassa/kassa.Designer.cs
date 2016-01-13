namespace Kassa
{
    partial class kassa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kassa));
            this.LbBestelling = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumAantal = new System.Windows.Forms.NumericUpDown();
            this.TbBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNieuwe = new System.Windows.Forms.Button();
            this.BtnRum = new System.Windows.Forms.Button();
            this.BtnTequila = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnVodka = new System.Windows.Forms.Button();
            this.BtnBier = new System.Windows.Forms.Button();
            this.BtnWijn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // LbBestelling
            // 
            this.LbBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBestelling.FormattingEnabled = true;
            this.LbBestelling.ItemHeight = 20;
            this.LbBestelling.Location = new System.Drawing.Point(1144, 410);
            this.LbBestelling.Name = "LbBestelling";
            this.LbBestelling.Size = new System.Drawing.Size(281, 284);
            this.LbBestelling.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1136, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestelling:";
            // 
            // NumAantal
            // 
            this.NumAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAantal.Location = new System.Drawing.Point(853, 410);
            this.NumAantal.Name = "NumAantal";
            this.NumAantal.Size = new System.Drawing.Size(172, 62);
            this.NumAantal.TabIndex = 13;
            // 
            // TbBarcode
            // 
            this.TbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbBarcode.Location = new System.Drawing.Point(853, 524);
            this.TbBarcode.Name = "TbBarcode";
            this.TbBarcode.Size = new System.Drawing.Size(172, 62);
            this.TbBarcode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(847, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aantal:";
            // 
            // BtnNieuwe
            // 
            this.BtnNieuwe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNieuwe.FlatAppearance.BorderSize = 0;
            this.BtnNieuwe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNieuwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNieuwe.Image = global::Kassa.Properties.Resources.knopkassa1;
            this.BtnNieuwe.Location = new System.Drawing.Point(853, 624);
            this.BtnNieuwe.Name = "BtnNieuwe";
            this.BtnNieuwe.Size = new System.Drawing.Size(172, 70);
            this.BtnNieuwe.TabIndex = 17;
            this.BtnNieuwe.Text = "Nieuwe Klant";
            this.BtnNieuwe.UseVisualStyleBackColor = true;
            this.BtnNieuwe.Click += new System.EventHandler(this.BtnNieuwe_Click);
            // 
            // BtnRum
            // 
            this.BtnRum.BackColor = System.Drawing.Color.Transparent;
            this.BtnRum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRum.FlatAppearance.BorderSize = 0;
            this.BtnRum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRum.Image = global::Kassa.Properties.Resources.kassarum_fw;
            this.BtnRum.Location = new System.Drawing.Point(104, 489);
            this.BtnRum.Name = "BtnRum";
            this.BtnRum.Size = new System.Drawing.Size(248, 155);
            this.BtnRum.TabIndex = 19;
            this.BtnRum.Text = " ";
            this.BtnRum.UseVisualStyleBackColor = false;
            this.BtnRum.Click += new System.EventHandler(this.BtnRum_Click);
            // 
            // BtnTequila
            // 
            this.BtnTequila.BackColor = System.Drawing.Color.Transparent;
            this.BtnTequila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTequila.FlatAppearance.BorderSize = 0;
            this.BtnTequila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTequila.Image = global::Kassa.Properties.Resources.Tequilakassa_fw;
            this.BtnTequila.Location = new System.Drawing.Point(104, 665);
            this.BtnTequila.Name = "BtnTequila";
            this.BtnTequila.Size = new System.Drawing.Size(248, 155);
            this.BtnTequila.TabIndex = 22;
            this.BtnTequila.Text = " ";
            this.BtnTequila.UseVisualStyleBackColor = false;
            this.BtnTequila.Click += new System.EventHandler(this.BtnTequila_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(385, 665);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 155);
            this.button6.TabIndex = 23;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnVodka
            // 
            this.BtnVodka.BackColor = System.Drawing.Color.Transparent;
            this.BtnVodka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVodka.FlatAppearance.BorderSize = 0;
            this.BtnVodka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVodka.Image = global::Kassa.Properties.Resources.kassavodka_fw;
            this.BtnVodka.Location = new System.Drawing.Point(385, 489);
            this.BtnVodka.Name = "BtnVodka";
            this.BtnVodka.Size = new System.Drawing.Size(248, 155);
            this.BtnVodka.TabIndex = 18;
            this.BtnVodka.Text = " ";
            this.BtnVodka.UseVisualStyleBackColor = false;
            this.BtnVodka.Click += new System.EventHandler(this.BtnVodka_Click);
            // 
            // BtnBier
            // 
            this.BtnBier.BackColor = System.Drawing.Color.Transparent;
            this.BtnBier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBier.FlatAppearance.BorderSize = 0;
            this.BtnBier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBier.Image = global::Kassa.Properties.Resources.kassabier_fw;
            this.BtnBier.Location = new System.Drawing.Point(104, 312);
            this.BtnBier.Name = "BtnBier";
            this.BtnBier.Size = new System.Drawing.Size(248, 155);
            this.BtnBier.TabIndex = 21;
            this.BtnBier.Text = " ";
            this.BtnBier.UseVisualStyleBackColor = false;
            this.BtnBier.Click += new System.EventHandler(this.BtnBier_Click);
            // 
            // BtnWijn
            // 
            this.BtnWijn.BackColor = System.Drawing.Color.Transparent;
            this.BtnWijn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWijn.FlatAppearance.BorderSize = 0;
            this.BtnWijn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWijn.Image = global::Kassa.Properties.Resources.kassawijn_fw;
            this.BtnWijn.Location = new System.Drawing.Point(385, 312);
            this.BtnWijn.Name = "BtnWijn";
            this.BtnWijn.Size = new System.Drawing.Size(248, 155);
            this.BtnWijn.TabIndex = 20;
            this.BtnWijn.Text = " ";
            this.BtnWijn.UseVisualStyleBackColor = false;
            this.BtnWijn.Click += new System.EventHandler(this.BtnWijn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kassa.Properties.Resources.Kassaclean_fw;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnRum);
            this.Controls.Add(this.BtnTequila);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BtnVodka);
            this.Controls.Add(this.BtnBier);
            this.Controls.Add(this.BtnWijn);
            this.Controls.Add(this.BtnNieuwe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbBarcode);
            this.Controls.Add(this.NumAantal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbBestelling);
            this.Name = "kassa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LbBestelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumAantal;
        private System.Windows.Forms.TextBox TbBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnNieuwe;
        private System.Windows.Forms.Button BtnRum;
        private System.Windows.Forms.Button BtnTequila;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnVodka;
        private System.Windows.Forms.Button BtnBier;
        private System.Windows.Forms.Button BtnWijn;
        private System.Windows.Forms.Button button1;
    }
}

