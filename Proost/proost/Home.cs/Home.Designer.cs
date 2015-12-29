namespace proost
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnBier = new System.Windows.Forms.Button();
            this.btnWijn = new System.Windows.Forms.Button();
            this.btnRum = new System.Windows.Forms.Button();
            this.btnVodka = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBier
            // 
            this.btnBier.BackColor = System.Drawing.Color.Transparent;
            this.btnBier.FlatAppearance.BorderSize = 0;
            this.btnBier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBier.Image = ((System.Drawing.Image)(resources.GetObject("btnBier.Image")));
            this.btnBier.Location = new System.Drawing.Point(55, 348);
            this.btnBier.Name = "btnBier";
            this.btnBier.Size = new System.Drawing.Size(93, 69);
            this.btnBier.TabIndex = 0;
            this.btnBier.UseVisualStyleBackColor = false;
            // 
            // btnWijn
            // 
            this.btnWijn.BackColor = System.Drawing.Color.Transparent;
            this.btnWijn.FlatAppearance.BorderSize = 0;
            this.btnWijn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWijn.Image = ((System.Drawing.Image)(resources.GetObject("btnWijn.Image")));
            this.btnWijn.Location = new System.Drawing.Point(154, 348);
            this.btnWijn.Name = "btnWijn";
            this.btnWijn.Size = new System.Drawing.Size(93, 69);
            this.btnWijn.TabIndex = 1;
            this.btnWijn.UseVisualStyleBackColor = false;
            // 
            // btnRum
            // 
            this.btnRum.BackColor = System.Drawing.Color.Transparent;
            this.btnRum.FlatAppearance.BorderSize = 0;
            this.btnRum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRum.Image = ((System.Drawing.Image)(resources.GetObject("btnRum.Image")));
            this.btnRum.Location = new System.Drawing.Point(198, 440);
            this.btnRum.Name = "btnRum";
            this.btnRum.Size = new System.Drawing.Size(93, 69);
            this.btnRum.TabIndex = 2;
            this.btnRum.UseVisualStyleBackColor = false;
            // 
            // btnVodka
            // 
            this.btnVodka.BackColor = System.Drawing.Color.Transparent;
            this.btnVodka.FlatAppearance.BorderSize = 0;
            this.btnVodka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVodka.Image = ((System.Drawing.Image)(resources.GetObject("btnVodka.Image")));
            this.btnVodka.Location = new System.Drawing.Point(99, 440);
            this.btnVodka.Name = "btnVodka";
            this.btnVodka.Size = new System.Drawing.Size(93, 69);
            this.btnVodka.TabIndex = 3;
            this.btnVodka.UseVisualStyleBackColor = false;
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.Transparent;
            this.btnTequila.FlatAppearance.BorderSize = 0;
            this.btnTequila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTequila.Image = ((System.Drawing.Image)(resources.GetObject("btnTequila.Image")));
            this.btnTequila.Location = new System.Drawing.Point(253, 348);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(93, 69);
            this.btnTequila.TabIndex = 4;
            this.btnTequila.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 736);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnVodka);
            this.Controls.Add(this.btnRum);
            this.Controls.Add(this.btnWijn);
            this.Controls.Add(this.btnBier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBier;
        private System.Windows.Forms.Button btnWijn;
        private System.Windows.Forms.Button btnRum;
        private System.Windows.Forms.Button btnVodka;
        private System.Windows.Forms.Button btnTequila;
    }
}