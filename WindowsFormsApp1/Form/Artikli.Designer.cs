namespace WindowsFormsApp1
{
    partial class Artikli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artikliZaZemljišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.djubrivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prirodnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veštačkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemikalijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćniArtikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciojeOZaposlenimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(293, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 602);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Odjavi se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliZaZemljišteToolStripMenuItem,
            this.pomoćniArtikliToolStripMenuItem,
            this.informaciojeOZaposlenimaToolStripMenuItem,
            this.računToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 25, 0, 25);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(253, 654);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artikliZaZemljišteToolStripMenuItem
            // 
            this.artikliZaZemljišteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.artikliZaZemljišteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.djubrivaToolStripMenuItem,
            this.semenaToolStripMenuItem,
            this.hemikalijeToolStripMenuItem});
            this.artikliZaZemljišteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artikliZaZemljišteToolStripMenuItem.Name = "artikliZaZemljišteToolStripMenuItem";
            this.artikliZaZemljišteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.artikliZaZemljišteToolStripMenuItem.Size = new System.Drawing.Size(244, 69);
            this.artikliZaZemljišteToolStripMenuItem.Text = "Artikli za zemljište";
            // 
            // djubrivaToolStripMenuItem
            // 
            this.djubrivaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prirodnaToolStripMenuItem,
            this.veštačkaToolStripMenuItem});
            this.djubrivaToolStripMenuItem.Name = "djubrivaToolStripMenuItem";
            this.djubrivaToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.djubrivaToolStripMenuItem.Text = "Djubriva";
            // 
            // prirodnaToolStripMenuItem
            // 
            this.prirodnaToolStripMenuItem.Name = "prirodnaToolStripMenuItem";
            this.prirodnaToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.prirodnaToolStripMenuItem.Text = "Prirodna";
            this.prirodnaToolStripMenuItem.Click += new System.EventHandler(this.prirodnaToolStripMenuItem_Click);
            // 
            // veštačkaToolStripMenuItem
            // 
            this.veštačkaToolStripMenuItem.Name = "veštačkaToolStripMenuItem";
            this.veštačkaToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.veštačkaToolStripMenuItem.Text = "Veštačka";
            this.veštačkaToolStripMenuItem.Click += new System.EventHandler(this.veštačkaToolStripMenuItem_Click);
            // 
            // semenaToolStripMenuItem
            // 
            this.semenaToolStripMenuItem.Name = "semenaToolStripMenuItem";
            this.semenaToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.semenaToolStripMenuItem.Text = "Semena";
            this.semenaToolStripMenuItem.Click += new System.EventHandler(this.semenaToolStripMenuItem_Click);
            // 
            // hemikalijeToolStripMenuItem
            // 
            this.hemikalijeToolStripMenuItem.Name = "hemikalijeToolStripMenuItem";
            this.hemikalijeToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.hemikalijeToolStripMenuItem.Text = "Hemikalije";
            this.hemikalijeToolStripMenuItem.Click += new System.EventHandler(this.hemikalijeToolStripMenuItem_Click);
            // 
            // pomoćniArtikliToolStripMenuItem
            // 
            this.pomoćniArtikliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomoćniArtikliToolStripMenuItem.Name = "pomoćniArtikliToolStripMenuItem";
            this.pomoćniArtikliToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.pomoćniArtikliToolStripMenuItem.Size = new System.Drawing.Size(244, 69);
            this.pomoćniArtikliToolStripMenuItem.Text = "Pomoćni artikli";
            this.pomoćniArtikliToolStripMenuItem.Click += new System.EventHandler(this.pomoćniArtikliToolStripMenuItem_Click);
            // 
            // informaciojeOZaposlenimaToolStripMenuItem
            // 
            this.informaciojeOZaposlenimaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informaciojeOZaposlenimaToolStripMenuItem.Name = "informaciojeOZaposlenimaToolStripMenuItem";
            this.informaciojeOZaposlenimaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.informaciojeOZaposlenimaToolStripMenuItem.Size = new System.Drawing.Size(244, 69);
            this.informaciojeOZaposlenimaToolStripMenuItem.Text = "Informacioje o zaposlenima";
            this.informaciojeOZaposlenimaToolStripMenuItem.Click += new System.EventHandler(this.informaciojeOZaposlenimaToolStripMenuItem_Click);
            // 
            // računToolStripMenuItem
            // 
            this.računToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.računToolStripMenuItem.Name = "računToolStripMenuItem";
            this.računToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.računToolStripMenuItem.Size = new System.Drawing.Size(244, 69);
            this.računToolStripMenuItem.Text = "Račun";
            this.računToolStripMenuItem.Click += new System.EventHandler(this.računToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.rasadjivanje_biljke_u_zemlju;
            this.pictureBox1.Location = new System.Drawing.Point(12, 493);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Artikli";
            this.Text = "Artikli";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artikliZaZemljišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem djubrivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prirodnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veštačkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemikalijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćniArtikliToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem informaciojeOZaposlenimaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem računToolStripMenuItem;
    }
}