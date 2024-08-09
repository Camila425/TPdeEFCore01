namespace TPdeEFCore01.Windows
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            BarramenuStrip = new MenuStrip();
            MarcasiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            GenerosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            DeportesiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            ColoresiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            ZapatosiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            TallesiconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            SaliriconMenuItem = new FontAwesome.Sharp.IconMenuItem();
            TitulomenuStrip = new MenuStrip();
            shoesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            Contenedorpanel = new Panel();
            pictureBox1 = new PictureBox();
            BarramenuStrip.SuspendLayout();
            TitulomenuStrip.SuspendLayout();
            Contenedorpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarramenuStrip
            // 
            BarramenuStrip.BackColor = SystemColors.ControlLight;
            BarramenuStrip.Items.AddRange(new ToolStripItem[] { MarcasiconMenuItem, GenerosiconMenuItem, DeportesiconMenuItem, ColoresiconMenuItem, ZapatosiconMenuItem, TallesiconMenuItem, SaliriconMenuItem });
            BarramenuStrip.Location = new Point(0, 47);
            BarramenuStrip.Name = "BarramenuStrip";
            BarramenuStrip.Size = new Size(847, 73);
            BarramenuStrip.TabIndex = 0;
            BarramenuStrip.Text = "menuStrip1";
            // 
            // MarcasiconMenuItem
            // 
            MarcasiconMenuItem.AutoSize = false;
            MarcasiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.PoundSign;
            MarcasiconMenuItem.IconColor = Color.Black;
            MarcasiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MarcasiconMenuItem.IconSize = 50;
            MarcasiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            MarcasiconMenuItem.Name = "MarcasiconMenuItem";
            MarcasiconMenuItem.Size = new Size(112, 69);
            MarcasiconMenuItem.Text = "Marcas";
            MarcasiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            MarcasiconMenuItem.Click += MarcasiconMenuItem_Click;
            // 
            // GenerosiconMenuItem
            // 
            GenerosiconMenuItem.AutoSize = false;
            GenerosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Person;
            GenerosiconMenuItem.IconColor = Color.Black;
            GenerosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GenerosiconMenuItem.IconSize = 50;
            GenerosiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            GenerosiconMenuItem.Name = "GenerosiconMenuItem";
            GenerosiconMenuItem.Size = new Size(112, 69);
            GenerosiconMenuItem.Text = "Generos";
            GenerosiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            GenerosiconMenuItem.Click += GenerosiconMenuItem_Click;
            // 
            // DeportesiconMenuItem
            // 
            DeportesiconMenuItem.AutoSize = false;
            DeportesiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.TableTennis;
            DeportesiconMenuItem.IconColor = Color.Black;
            DeportesiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeportesiconMenuItem.IconSize = 50;
            DeportesiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            DeportesiconMenuItem.Name = "DeportesiconMenuItem";
            DeportesiconMenuItem.Size = new Size(112, 69);
            DeportesiconMenuItem.Text = "Deportes";
            DeportesiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            DeportesiconMenuItem.Click += DeportesiconMenuItem_Click;
            // 
            // ColoresiconMenuItem
            // 
            ColoresiconMenuItem.AutoSize = false;
            ColoresiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            ColoresiconMenuItem.IconColor = Color.Black;
            ColoresiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ColoresiconMenuItem.IconSize = 50;
            ColoresiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ColoresiconMenuItem.Name = "ColoresiconMenuItem";
            ColoresiconMenuItem.Size = new Size(112, 69);
            ColoresiconMenuItem.Text = "Colores";
            ColoresiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            ColoresiconMenuItem.Click += ColoresiconMenuItem_Click;
            // 
            // ZapatosiconMenuItem
            // 
            ZapatosiconMenuItem.AutoSize = false;
            ZapatosiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            ZapatosiconMenuItem.IconColor = Color.Black;
            ZapatosiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ZapatosiconMenuItem.IconSize = 50;
            ZapatosiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ZapatosiconMenuItem.Name = "ZapatosiconMenuItem";
            ZapatosiconMenuItem.Size = new Size(112, 69);
            ZapatosiconMenuItem.Text = "Zapatos";
            ZapatosiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            ZapatosiconMenuItem.Click += ZapatosiconMenuItem_Click;
            // 
            // TallesiconMenuItem
            // 
            TallesiconMenuItem.AutoSize = false;
            TallesiconMenuItem.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            TallesiconMenuItem.IconColor = Color.Black;
            TallesiconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TallesiconMenuItem.IconSize = 50;
            TallesiconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            TallesiconMenuItem.Name = "TallesiconMenuItem";
            TallesiconMenuItem.Size = new Size(112, 69);
            TallesiconMenuItem.Text = "Talles";
            TallesiconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            TallesiconMenuItem.Click += TallesiconMenuItem_Click;
            // 
            // SaliriconMenuItem
            // 
            SaliriconMenuItem.AutoSize = false;
            SaliriconMenuItem.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkSquareAlt;
            SaliriconMenuItem.IconColor = Color.Black;
            SaliriconMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SaliriconMenuItem.IconSize = 50;
            SaliriconMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SaliriconMenuItem.Name = "SaliriconMenuItem";
            SaliriconMenuItem.Size = new Size(120, 69);
            SaliriconMenuItem.Text = "Salir";
            SaliriconMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            SaliriconMenuItem.Click += SaliriconMenuItem_Click_1;
            // 
            // TitulomenuStrip
            // 
            TitulomenuStrip.AutoSize = false;
            TitulomenuStrip.BackColor = SystemColors.ActiveBorder;
            TitulomenuStrip.Items.AddRange(new ToolStripItem[] { shoesToolStripMenuItem, toolStripMenuItem1 });
            TitulomenuStrip.Location = new Point(0, 0);
            TitulomenuStrip.Name = "TitulomenuStrip";
            TitulomenuStrip.RightToLeft = RightToLeft.Yes;
            TitulomenuStrip.Size = new Size(847, 47);
            TitulomenuStrip.TabIndex = 1;
            TitulomenuStrip.Text = "menuStrip2";
            // 
            // shoesToolStripMenuItem
            // 
            shoesToolStripMenuItem.Image = (Image)resources.GetObject("shoesToolStripMenuItem.Image");
            shoesToolStripMenuItem.Margin = new Padding(1, 1, 355, 1);
            shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            shoesToolStripMenuItem.Size = new Size(111, 41);
            shoesToolStripMenuItem.Text = "Zapatos y Más";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 43);
            toolStripMenuItem1.Text = " ";
            // 
            // Contenedorpanel
            // 
            Contenedorpanel.Controls.Add(pictureBox1);
            Contenedorpanel.Dock = DockStyle.Fill;
            Contenedorpanel.Location = new Point(0, 120);
            Contenedorpanel.Name = "Contenedorpanel";
            Contenedorpanel.Size = new Size(847, 427);
            Contenedorpanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(841, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 547);
            ControlBox = false;
            Controls.Add(Contenedorpanel);
            Controls.Add(BarramenuStrip);
            Controls.Add(TitulomenuStrip);
            MainMenuStrip = BarramenuStrip;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            BarramenuStrip.ResumeLayout(false);
            BarramenuStrip.PerformLayout();
            TitulomenuStrip.ResumeLayout(false);
            TitulomenuStrip.PerformLayout();
            Contenedorpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip BarramenuStrip;
        private MenuStrip TitulomenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private FontAwesome.Sharp.IconMenuItem MarcasiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem GenerosiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem DeportesiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem ColoresiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem ZapatosiconMenuItem;
        private Panel Contenedorpanel;
        private ToolStripMenuItem shoesToolStripMenuItem;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem TallesiconMenuItem;
        private FontAwesome.Sharp.IconMenuItem SaliriconMenuItem;
    }
}