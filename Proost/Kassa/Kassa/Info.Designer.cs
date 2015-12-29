namespace Kassa
{
    partial class Info
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.drankChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblBier = new System.Windows.Forms.Label();
            this.lblWijn = new System.Windows.Forms.Label();
            this.lblRum = new System.Windows.Forms.Label();
            this.lblWodka = new System.Windows.Forms.Label();
            this.lblTequila = new System.Windows.Forms.Label();
            this.lblAantalTequila = new System.Windows.Forms.Label();
            this.lblAantalWodka = new System.Windows.Forms.Label();
            this.lblAantalRum = new System.Windows.Forms.Label();
            this.lblAantalWijn = new System.Windows.Forms.Label();
            this.lblAantalBier = new System.Windows.Forms.Label();
            this.lblTotaalAantal = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.drankChart)).BeginInit();
            this.SuspendLayout();
            // 
            // drankChart
            // 
            chartArea5.Name = "ChartArea1";
            this.drankChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.drankChart.Legends.Add(legend5);
            this.drankChart.Location = new System.Drawing.Point(911, 482);
            this.drankChart.Name = "drankChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Aantal";
            this.drankChart.Series.Add(series5);
            this.drankChart.Size = new System.Drawing.Size(558, 322);
            this.drankChart.TabIndex = 0;
            this.drankChart.Text = "chart1";
            this.drankChart.Click += new System.EventHandler(this.drankChart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1117, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Totaal:";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 12);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(120, 55);
            this.btnTerug.TabIndex = 19;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lblBier
            // 
            this.lblBier.BackColor = System.Drawing.Color.Transparent;
            this.lblBier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBier.Location = new System.Drawing.Point(98, 605);
            this.lblBier.Name = "lblBier";
            this.lblBier.Size = new System.Drawing.Size(124, 31);
            this.lblBier.TabIndex = 20;
            this.lblBier.Text = "Bier:";
            this.lblBier.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWijn
            // 
            this.lblWijn.BackColor = System.Drawing.Color.Transparent;
            this.lblWijn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWijn.Location = new System.Drawing.Point(97, 648);
            this.lblWijn.Name = "lblWijn";
            this.lblWijn.Size = new System.Drawing.Size(124, 31);
            this.lblWijn.TabIndex = 21;
            this.lblWijn.Text = "Wijn:";
            // 
            // lblRum
            // 
            this.lblRum.BackColor = System.Drawing.Color.Transparent;
            this.lblRum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRum.Location = new System.Drawing.Point(97, 690);
            this.lblRum.Name = "lblRum";
            this.lblRum.Size = new System.Drawing.Size(124, 31);
            this.lblRum.TabIndex = 22;
            this.lblRum.Text = "Rum:";
            this.lblRum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblWodka
            // 
            this.lblWodka.BackColor = System.Drawing.Color.Transparent;
            this.lblWodka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWodka.Location = new System.Drawing.Point(98, 734);
            this.lblWodka.Name = "lblWodka";
            this.lblWodka.Size = new System.Drawing.Size(124, 31);
            this.lblWodka.TabIndex = 23;
            this.lblWodka.Text = "Wodka:";
            // 
            // lblTequila
            // 
            this.lblTequila.BackColor = System.Drawing.Color.Transparent;
            this.lblTequila.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTequila.Location = new System.Drawing.Point(97, 774);
            this.lblTequila.Name = "lblTequila";
            this.lblTequila.Size = new System.Drawing.Size(124, 31);
            this.lblTequila.TabIndex = 24;
            this.lblTequila.Text = "Tequila:";
            // 
            // lblAantalTequila
            // 
            this.lblAantalTequila.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalTequila.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalTequila.Location = new System.Drawing.Point(227, 774);
            this.lblAantalTequila.Name = "lblAantalTequila";
            this.lblAantalTequila.Size = new System.Drawing.Size(124, 31);
            this.lblAantalTequila.TabIndex = 25;
            this.lblAantalTequila.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblAantalWodka
            // 
            this.lblAantalWodka.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalWodka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalWodka.Location = new System.Drawing.Point(227, 734);
            this.lblAantalWodka.Name = "lblAantalWodka";
            this.lblAantalWodka.Size = new System.Drawing.Size(124, 31);
            this.lblAantalWodka.TabIndex = 26;
            // 
            // lblAantalRum
            // 
            this.lblAantalRum.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalRum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalRum.Location = new System.Drawing.Point(227, 690);
            this.lblAantalRum.Name = "lblAantalRum";
            this.lblAantalRum.Size = new System.Drawing.Size(124, 31);
            this.lblAantalRum.TabIndex = 27;
            // 
            // lblAantalWijn
            // 
            this.lblAantalWijn.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalWijn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalWijn.Location = new System.Drawing.Point(227, 648);
            this.lblAantalWijn.Name = "lblAantalWijn";
            this.lblAantalWijn.Size = new System.Drawing.Size(124, 31);
            this.lblAantalWijn.TabIndex = 28;
            // 
            // lblAantalBier
            // 
            this.lblAantalBier.BackColor = System.Drawing.Color.Transparent;
            this.lblAantalBier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalBier.Location = new System.Drawing.Point(228, 605);
            this.lblAantalBier.Name = "lblAantalBier";
            this.lblAantalBier.Size = new System.Drawing.Size(124, 31);
            this.lblAantalBier.TabIndex = 29;
            // 
            // lblTotaalAantal
            // 
            this.lblTotaalAantal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotaalAantal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaalAantal.Location = new System.Drawing.Point(228, 553);
            this.lblTotaalAantal.Name = "lblTotaalAantal";
            this.lblTotaalAantal.Size = new System.Drawing.Size(124, 31);
            this.lblTotaalAantal.TabIndex = 30;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(911, 439);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 33;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(1269, 439);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Target";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(406, 772);
            this.progressBar1.Maximum = 350;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(363, 31);
            this.progressBar1.TabIndex = 36;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kassa.Properties.Resources.Kassaclean_fw;
            this.ClientSize = new System.Drawing.Size(1514, 966);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.lblTotaalAantal);
            this.Controls.Add(this.lblAantalBier);
            this.Controls.Add(this.lblAantalWijn);
            this.Controls.Add(this.lblAantalRum);
            this.Controls.Add(this.lblAantalWodka);
            this.Controls.Add(this.lblAantalTequila);
            this.Controls.Add(this.lblTequila);
            this.Controls.Add(this.lblWodka);
            this.Controls.Add(this.lblRum);
            this.Controls.Add(this.lblWijn);
            this.Controls.Add(this.lblBier);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drankChart);
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.drankChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart drankChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblBier;
        private System.Windows.Forms.Label lblWijn;
        private System.Windows.Forms.Label lblRum;
        private System.Windows.Forms.Label lblWodka;
        private System.Windows.Forms.Label lblTequila;
        private System.Windows.Forms.Label lblAantalTequila;
        private System.Windows.Forms.Label lblAantalWodka;
        private System.Windows.Forms.Label lblAantalRum;
        private System.Windows.Forms.Label lblAantalBier;
        private System.Windows.Forms.Label lblTotaalAantal;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label lblAantalWijn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}