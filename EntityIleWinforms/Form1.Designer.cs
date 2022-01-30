namespace EntityIleWinforms
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriFormAc = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_urun = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.tedarikçiİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_KategoriFormAc,
            this.TSMI_urun});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.işlemlerToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // TSMI_KategoriFormAc
            // 
            this.TSMI_KategoriFormAc.Name = "TSMI_KategoriFormAc";
            this.TSMI_KategoriFormAc.Size = new System.Drawing.Size(180, 22);
            this.TSMI_KategoriFormAc.Text = "Kategori İşlemleri";
            this.TSMI_KategoriFormAc.Click += new System.EventHandler(this.TSMI_KategoriFormAc_Click);
            // 
            // TSMI_urun
            // 
            this.TSMI_urun.Name = "TSMI_urun";
            this.TSMI_urun.Size = new System.Drawing.Size(180, 22);
            this.TSMI_urun.Text = "Ürün İşlemleri";
            this.TSMI_urun.Click += new System.EventHandler(this.TSMI_urun_Click);
            // 
            // tedarikçiİşlemleriToolStripMenuItem
            // 
            this.tedarikçiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tedarikçilerToolStripMenuItem});
            this.tedarikçiİşlemleriToolStripMenuItem.Name = "tedarikçiİşlemleriToolStripMenuItem";
            this.tedarikçiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.tedarikçiİşlemleriToolStripMenuItem.Text = "Tedarikçi işlemleri";
            // 
            // tedarikçilerToolStripMenuItem
            // 
            this.tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            this.tedarikçilerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Northwind";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriFormAc;
        private System.Windows.Forms.ToolStripMenuItem TSMI_urun;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
    }
}

