namespace sagliktakipsistemi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.pnl_veri = new System.Windows.Forms.Panel();
            this.pnl_diyet = new System.Windows.Forms.Panel();
            this.pnl_egzersiz = new System.Windows.Forms.Panel();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_veri
            // 
            this.pnl_veri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_veri.Location = new System.Drawing.Point(74, 128);
            this.pnl_veri.Name = "pnl_veri";
            this.pnl_veri.Size = new System.Drawing.Size(177, 169);
            this.pnl_veri.TabIndex = 0;
            this.pnl_veri.Click += new System.EventHandler(this.pnl_veri_Click);
            // 
            // pnl_diyet
            // 
            this.pnl_diyet.BackColor = System.Drawing.Color.Transparent;
            this.pnl_diyet.Location = new System.Drawing.Point(285, 128);
            this.pnl_diyet.Name = "pnl_diyet";
            this.pnl_diyet.Size = new System.Drawing.Size(177, 169);
            this.pnl_diyet.TabIndex = 1;
            this.pnl_diyet.Click += new System.EventHandler(this.pnl_diyet_Click);
            // 
            // pnl_egzersiz
            // 
            this.pnl_egzersiz.BackColor = System.Drawing.Color.Transparent;
            this.pnl_egzersiz.Location = new System.Drawing.Point(73, 327);
            this.pnl_egzersiz.Name = "pnl_egzersiz";
            this.pnl_egzersiz.Size = new System.Drawing.Size(177, 169);
            this.pnl_egzersiz.TabIndex = 2;
            this.pnl_egzersiz.Click += new System.EventHandler(this.pnl_egzersiz_Click);
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(285, 327);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(177, 169);
            this.pnl_cikis.TabIndex = 3;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.pnl_egzersiz);
            this.Controls.Add(this.pnl_diyet);
            this.Controls.Add(this.pnl_veri);
            this.Name = "anasayfa";
            this.Text = "Sağlık Takip Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_veri;
        private System.Windows.Forms.Panel pnl_diyet;
        private System.Windows.Forms.Panel pnl_egzersiz;
        private System.Windows.Forms.Panel pnl_cikis;
    }
}