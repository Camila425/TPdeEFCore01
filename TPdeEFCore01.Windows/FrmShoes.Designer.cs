namespace TPdeEFCore01.Windows
{
    partial class FrmShoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShoes));
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            NuevotoolStripButton = new ToolStripButton();
            BorrartoolStripButton = new ToolStripButton();
            EditartoolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            FltrarrtoolStripButton = new ToolStripDropDownButton();
            MarcassToolStripMenuItem = new ToolStripMenuItem();
            marcassCb = new ToolStripComboBox();
            generosToolStripMenuItem = new ToolStripMenuItem();
            GenerostoolStripComboBox = new ToolStripComboBox();
            deportesToolStripMenuItem = new ToolStripMenuItem();
            DeportestoolStripComboBox = new ToolStripComboBox();
            ActualizartoolStripButton = new ToolStripButton();
            BuscarMarcaEntreDosPreciostoolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BuscarMaryDeptoolStripButton = new ToolStripButton();
            GeneroYDeportetoolStripButton = new ToolStripButton();
            TallestoolStripButton = new ToolStripButton();
            AsignarTalletoolStripButton = new ToolStripButton();
            AgregarStocktoolStripButton = new ToolStripButton();
            EliminarTalletoolStripButton = new ToolStripButton();
            OrdentoolStripButton = new ToolStripDropDownButton();
            aZToolStripMenuItem = new ToolStripMenuItem();
            zAToolStripMenuItem = new ToolStripMenuItem();
            menorPrecioToolStripMenuItem = new ToolStripMenuItem();
            mayorPrecioToolStripMenuItem = new ToolStripMenuItem();
            anteriorbutton = new Button();
            Siguientebutton = new Button();
            Ultimobutton = new Button();
            Primerobutton = new Button();
            CantRegistrostextBox = new TextBox();
            label2 = new Label();
            PaginascomboBox = new ComboBox();
            label1 = new Label();
            DatosdataGridView = new DataGridView();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColBrand = new DataGridViewTextBoxColumn();
            ColGenre = new DataGridViewTextBoxColumn();
            ColSport = new DataGridViewTextBoxColumn();
            ColColor = new DataGridViewTextBoxColumn();
            ColModelo = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColQuantityInStock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DatosdataGridView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(anteriorbutton);
            splitContainer1.Panel2.Controls.Add(Siguientebutton);
            splitContainer1.Panel2.Controls.Add(Ultimobutton);
            splitContainer1.Panel2.Controls.Add(Primerobutton);
            splitContainer1.Panel2.Controls.Add(CantRegistrostextBox);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(PaginascomboBox);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(DatosdataGridView);
            splitContainer1.Size = new Size(895, 396);
            splitContainer1.SplitterDistance = 66;
            splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { NuevotoolStripButton, BorrartoolStripButton, EditartoolStripButton, toolStripSeparator1, FltrarrtoolStripButton, ActualizartoolStripButton, BuscarMarcaEntreDosPreciostoolStripButton, toolStripSeparator2, BuscarMaryDeptoolStripButton, GeneroYDeportetoolStripButton, TallestoolStripButton, AsignarTalletoolStripButton, AgregarStocktoolStripButton, EliminarTalletoolStripButton, OrdentoolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(895, 58);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton
            // 
            NuevotoolStripButton.Image = (Image)resources.GetObject("NuevotoolStripButton.Image");
            NuevotoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            NuevotoolStripButton.ImageTransparentColor = Color.Magenta;
            NuevotoolStripButton.Name = "NuevotoolStripButton";
            NuevotoolStripButton.Size = new Size(46, 55);
            NuevotoolStripButton.Text = "Nuevo";
            NuevotoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            NuevotoolStripButton.Click += NuevotoolStripButton_Click;
            // 
            // BorrartoolStripButton
            // 
            BorrartoolStripButton.Image = (Image)resources.GetObject("BorrartoolStripButton.Image");
            BorrartoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            BorrartoolStripButton.ImageTransparentColor = Color.Magenta;
            BorrartoolStripButton.Name = "BorrartoolStripButton";
            BorrartoolStripButton.Size = new Size(43, 55);
            BorrartoolStripButton.Text = "Borrar";
            BorrartoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BorrartoolStripButton.Click += BorrartoolStripButton_Click;
            // 
            // EditartoolStripButton
            // 
            EditartoolStripButton.Image = (Image)resources.GetObject("EditartoolStripButton.Image");
            EditartoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            EditartoolStripButton.ImageTransparentColor = Color.Magenta;
            EditartoolStripButton.Name = "EditartoolStripButton";
            EditartoolStripButton.Size = new Size(41, 55);
            EditartoolStripButton.Text = "Editar";
            EditartoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            EditartoolStripButton.Click += EditartoolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // FltrarrtoolStripButton
            // 
            FltrarrtoolStripButton.DropDownItems.AddRange(new ToolStripItem[] { MarcassToolStripMenuItem, generosToolStripMenuItem, deportesToolStripMenuItem });
            FltrarrtoolStripButton.Image = Properties.Resources.filter_36px;
            FltrarrtoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            FltrarrtoolStripButton.ImageTransparentColor = Color.Magenta;
            FltrarrtoolStripButton.Name = "FltrarrtoolStripButton";
            FltrarrtoolStripButton.Size = new Size(50, 55);
            FltrarrtoolStripButton.Text = "Filtrar";
            FltrarrtoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MarcassToolStripMenuItem
            // 
            MarcassToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marcassCb });
            MarcassToolStripMenuItem.Name = "MarcassToolStripMenuItem";
            MarcassToolStripMenuItem.Size = new Size(121, 22);
            MarcassToolStripMenuItem.Text = "Marcas";
            // 
            // marcassCb
            // 
            marcassCb.DropDownStyle = ComboBoxStyle.DropDownList;
            marcassCb.Name = "marcassCb";
            marcassCb.Size = new Size(121, 23);
            marcassCb.SelectedIndexChanged += marcassCb_SelectedIndexChanged;
            // 
            // generosToolStripMenuItem
            // 
            generosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GenerostoolStripComboBox });
            generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            generosToolStripMenuItem.Size = new Size(121, 22);
            generosToolStripMenuItem.Text = "Generos";
            // 
            // GenerostoolStripComboBox
            // 
            GenerostoolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenerostoolStripComboBox.Name = "GenerostoolStripComboBox";
            GenerostoolStripComboBox.Size = new Size(121, 23);
            GenerostoolStripComboBox.SelectedIndexChanged += GenerostoolStripComboBox_SelectedIndexChanged;
            // 
            // deportesToolStripMenuItem
            // 
            deportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeportestoolStripComboBox });
            deportesToolStripMenuItem.Name = "deportesToolStripMenuItem";
            deportesToolStripMenuItem.Size = new Size(121, 22);
            deportesToolStripMenuItem.Text = "Deportes";
            // 
            // DeportestoolStripComboBox
            // 
            DeportestoolStripComboBox.Name = "DeportestoolStripComboBox";
            DeportestoolStripComboBox.Size = new Size(121, 23);
            DeportestoolStripComboBox.SelectedIndexChanged += DeportestoolStripComboBox_SelectedIndexChanged;
            // 
            // ActualizartoolStripButton
            // 
            ActualizartoolStripButton.Image = (Image)resources.GetObject("ActualizartoolStripButton.Image");
            ActualizartoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ActualizartoolStripButton.ImageTransparentColor = Color.Magenta;
            ActualizartoolStripButton.Name = "ActualizartoolStripButton";
            ActualizartoolStripButton.Size = new Size(63, 55);
            ActualizartoolStripButton.Text = "Actualizar";
            ActualizartoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ActualizartoolStripButton.Click += ActualizartoolStripButton_Click_1;
            // 
            // BuscarMarcaEntreDosPreciostoolStripButton
            // 
            BuscarMarcaEntreDosPreciostoolStripButton.Image = (Image)resources.GetObject("BuscarMarcaEntreDosPreciostoolStripButton.Image");
            BuscarMarcaEntreDosPreciostoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            BuscarMarcaEntreDosPreciostoolStripButton.ImageTransparentColor = Color.Magenta;
            BuscarMarcaEntreDosPreciostoolStripButton.Name = "BuscarMarcaEntreDosPreciostoolStripButton";
            BuscarMarcaEntreDosPreciostoolStripButton.Size = new Size(72, 55);
            BuscarMarcaEntreDosPreciostoolStripButton.Text = "Mar-2 Prec.";
            BuscarMarcaEntreDosPreciostoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BuscarMarcaEntreDosPreciostoolStripButton.Click += BuscarMarcaEntreDosPreciostoolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 58);
            // 
            // BuscarMaryDeptoolStripButton
            // 
            BuscarMaryDeptoolStripButton.Image = (Image)resources.GetObject("BuscarMaryDeptoolStripButton.Image");
            BuscarMaryDeptoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            BuscarMaryDeptoolStripButton.ImageTransparentColor = Color.Magenta;
            BuscarMaryDeptoolStripButton.Name = "BuscarMaryDeptoolStripButton";
            BuscarMaryDeptoolStripButton.Size = new Size(66, 55);
            BuscarMaryDeptoolStripButton.Text = "Mar Y Dep";
            BuscarMaryDeptoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            BuscarMaryDeptoolStripButton.Click += BuscarMaryDeptoolStripButton_Click;
            // 
            // GeneroYDeportetoolStripButton
            // 
            GeneroYDeportetoolStripButton.Image = (Image)resources.GetObject("GeneroYDeportetoolStripButton.Image");
            GeneroYDeportetoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            GeneroYDeportetoolStripButton.ImageTransparentColor = Color.Magenta;
            GeneroYDeportetoolStripButton.Name = "GeneroYDeportetoolStripButton";
            GeneroYDeportetoolStripButton.Size = new Size(66, 55);
            GeneroYDeportetoolStripButton.Text = "Gen Y Dep";
            GeneroYDeportetoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            GeneroYDeportetoolStripButton.Click += GeneroYDeportetoolStripButton_Click;
            // 
            // TallestoolStripButton
            // 
            TallestoolStripButton.Image = (Image)resources.GetObject("TallestoolStripButton.Image");
            TallestoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            TallestoolStripButton.ImageTransparentColor = Color.Magenta;
            TallestoolStripButton.Name = "TallestoolStripButton";
            TallestoolStripButton.Size = new Size(107, 55);
            TallestoolStripButton.Text = "Cant Shoes xTalles";
            TallestoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            TallestoolStripButton.Click += TallestoolStripButton_Click;
            // 
            // AsignarTalletoolStripButton
            // 
            AsignarTalletoolStripButton.Image = (Image)resources.GetObject("AsignarTalletoolStripButton.Image");
            AsignarTalletoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            AsignarTalletoolStripButton.ImageTransparentColor = Color.Magenta;
            AsignarTalletoolStripButton.Name = "AsignarTalletoolStripButton";
            AsignarTalletoolStripButton.Size = new Size(63, 55);
            AsignarTalletoolStripButton.Text = "Agr-Talles";
            AsignarTalletoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AsignarTalletoolStripButton.Click += AsignarTalletoolStripButton_Click;
            // 
            // AgregarStocktoolStripButton
            // 
            AgregarStocktoolStripButton.Image = Properties.Resources.tasklist_36px;
            AgregarStocktoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            AgregarStocktoolStripButton.ImageTransparentColor = Color.Magenta;
            AgregarStocktoolStripButton.Name = "AgregarStocktoolStripButton";
            AgregarStocktoolStripButton.Size = new Size(64, 55);
            AgregarStocktoolStripButton.Text = "Agr-Stock";
            AgregarStocktoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            AgregarStocktoolStripButton.Click += AgregarStocktoolStripButton_Click;
            // 
            // EliminarTalletoolStripButton
            // 
            EliminarTalletoolStripButton.Image = (Image)resources.GetObject("EliminarTalletoolStripButton.Image");
            EliminarTalletoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            EliminarTalletoolStripButton.ImageTransparentColor = Color.Magenta;
            EliminarTalletoolStripButton.Name = "EliminarTalletoolStripButton";
            EliminarTalletoolStripButton.Size = new Size(67, 55);
            EliminarTalletoolStripButton.Text = "Elim-Talles";
            EliminarTalletoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            EliminarTalletoolStripButton.Click += EliminarTalletoolStripButton_Click;
            // 
            // OrdentoolStripButton
            // 
            OrdentoolStripButton.DropDownItems.AddRange(new ToolStripItem[] { aZToolStripMenuItem, zAToolStripMenuItem, menorPrecioToolStripMenuItem, mayorPrecioToolStripMenuItem });
            OrdentoolStripButton.Image = Properties.Resources.todo_list_36px;
            OrdentoolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            OrdentoolStripButton.ImageTransparentColor = Color.Magenta;
            OrdentoolStripButton.Name = "OrdentoolStripButton";
            OrdentoolStripButton.Size = new Size(53, 55);
            OrdentoolStripButton.Text = "Orden";
            OrdentoolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // aZToolStripMenuItem
            // 
            aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            aZToolStripMenuItem.Size = new Size(145, 22);
            aZToolStripMenuItem.Text = "A-Z";
            aZToolStripMenuItem.Click += aZToolStripMenuItem_Click;
            // 
            // zAToolStripMenuItem
            // 
            zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            zAToolStripMenuItem.Size = new Size(145, 22);
            zAToolStripMenuItem.Text = "Z-A";
            zAToolStripMenuItem.Click += zAToolStripMenuItem_Click;
            // 
            // menorPrecioToolStripMenuItem
            // 
            menorPrecioToolStripMenuItem.Name = "menorPrecioToolStripMenuItem";
            menorPrecioToolStripMenuItem.Size = new Size(145, 22);
            menorPrecioToolStripMenuItem.Text = "Menor Precio";
            menorPrecioToolStripMenuItem.Click += menorPrecioToolStripMenuItem_Click;
            // 
            // mayorPrecioToolStripMenuItem
            // 
            mayorPrecioToolStripMenuItem.Name = "mayorPrecioToolStripMenuItem";
            mayorPrecioToolStripMenuItem.Size = new Size(145, 22);
            mayorPrecioToolStripMenuItem.Text = "Mayor Precio";
            mayorPrecioToolStripMenuItem.Click += mayorPrecioToolStripMenuItem_Click;
            // 
            // anteriorbutton
            // 
            anteriorbutton.Image = Properties.Resources.previous_48px;
            anteriorbutton.Location = new Point(482, 310);
            anteriorbutton.Name = "anteriorbutton";
            anteriorbutton.Size = new Size(75, 39);
            anteriorbutton.TabIndex = 16;
            anteriorbutton.UseVisualStyleBackColor = true;
            anteriorbutton.Click += anteriorbutton_Click;
            // 
            // Siguientebutton
            // 
            Siguientebutton.Image = Properties.Resources.next_48px;
            Siguientebutton.Location = new Point(580, 310);
            Siguientebutton.Name = "Siguientebutton";
            Siguientebutton.Size = new Size(75, 39);
            Siguientebutton.TabIndex = 15;
            Siguientebutton.UseVisualStyleBackColor = true;
            Siguientebutton.Click += Siguientebutton_Click;
            // 
            // Ultimobutton
            // 
            Ultimobutton.Image = Properties.Resources.last_48px;
            Ultimobutton.Location = new Point(673, 310);
            Ultimobutton.Name = "Ultimobutton";
            Ultimobutton.Size = new Size(75, 39);
            Ultimobutton.TabIndex = 14;
            Ultimobutton.UseVisualStyleBackColor = true;
            Ultimobutton.Click += Ultimobutton_Click;
            // 
            // Primerobutton
            // 
            Primerobutton.Image = Properties.Resources.first_48px;
            Primerobutton.Location = new Point(389, 310);
            Primerobutton.Name = "Primerobutton";
            Primerobutton.Size = new Size(75, 39);
            Primerobutton.TabIndex = 13;
            Primerobutton.UseVisualStyleBackColor = true;
            Primerobutton.Click += Primerobutton_Click;
            // 
            // CantRegistrostextBox
            // 
            CantRegistrostextBox.Location = new Point(131, 317);
            CantRegistrostextBox.Name = "CantRegistrostextBox";
            CantRegistrostextBox.Size = new Size(22, 23);
            CantRegistrostextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 322);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 11;
            label2.Text = "De";
            // 
            // PaginascomboBox
            // 
            PaginascomboBox.FormattingEnabled = true;
            PaginascomboBox.Location = new Point(42, 319);
            PaginascomboBox.Name = "PaginascomboBox";
            PaginascomboBox.Size = new Size(56, 23);
            PaginascomboBox.TabIndex = 10;
            PaginascomboBox.SelectedIndexChanged += PaginascomboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 322);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "pag:";
            // 
            // DatosdataGridView
            // 
            DatosdataGridView.AllowUserToAddRows = false;
            DatosdataGridView.AllowUserToDeleteRows = false;
            DatosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosdataGridView.Columns.AddRange(new DataGridViewColumn[] { ColDescripcion, ColBrand, ColGenre, ColSport, ColColor, ColModelo, ColPrecio, ColQuantityInStock });
            DatosdataGridView.Location = new Point(0, 0);
            DatosdataGridView.Name = "DatosdataGridView";
            DatosdataGridView.ReadOnly = true;
            DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosdataGridView.Size = new Size(892, 284);
            DatosdataGridView.TabIndex = 0;
            // 
            // ColDescripcion
            // 
            ColDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDescripcion.HeaderText = "Descripcion";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            // 
            // ColBrand
            // 
            ColBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColBrand.HeaderText = "Marca";
            ColBrand.Name = "ColBrand";
            ColBrand.ReadOnly = true;
            ColBrand.Width = 65;
            // 
            // ColGenre
            // 
            ColGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColGenre.HeaderText = "Genero";
            ColGenre.Name = "ColGenre";
            ColGenre.ReadOnly = true;
            ColGenre.Width = 70;
            // 
            // ColSport
            // 
            ColSport.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColSport.HeaderText = "Deporte";
            ColSport.Name = "ColSport";
            ColSport.ReadOnly = true;
            ColSport.Width = 74;
            // 
            // ColColor
            // 
            ColColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColColor.HeaderText = "Color";
            ColColor.Name = "ColColor";
            ColColor.ReadOnly = true;
            ColColor.Width = 61;
            // 
            // ColModelo
            // 
            ColModelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColModelo.HeaderText = "Modelo";
            ColModelo.Name = "ColModelo";
            ColModelo.ReadOnly = true;
            ColModelo.Width = 73;
            // 
            // ColPrecio
            // 
            ColPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 65;
            // 
            // ColQuantityInStock
            // 
            ColQuantityInStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColQuantityInStock.HeaderText = "QuantityInStock";
            ColQuantityInStock.Name = "ColQuantityInStock";
            ColQuantityInStock.ReadOnly = true;
            ColQuantityInStock.Width = 117;
            // 
            // FrmShoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 396);
            Controls.Add(splitContainer1);
            Name = "FrmShoes";
            Text = "FrmShoes";
            Load += FrmShoes_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DatosdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton NuevotoolStripButton;
        private ToolStripButton BorrartoolStripButton;
        private ToolStripButton EditartoolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridView DatosdataGridView;
        private Button anteriorbutton;
        private Button Siguientebutton;
        private Button Ultimobutton;
        private Button Primerobutton;
        private TextBox CantRegistrostextBox;
        private Label label2;
        private ComboBox PaginascomboBox;
        private Label label1;
        private ToolStripDropDownButton FltrarrtoolStripButton;
        private ToolStripMenuItem MarcassToolStripMenuItem;
        private ToolStripComboBox marcassCb;
        private ToolStripMenuItem generosToolStripMenuItem;
        private ToolStripComboBox GenerostoolStripComboBox;
        private ToolStripMenuItem deportesToolStripMenuItem;
        private ToolStripComboBox DeportestoolStripComboBox;
        private ToolStripButton BuscarMaryDeptoolStripButton;
        private ToolStripButton GeneroYDeportetoolStripButton;
        private ToolStripButton ActualizartoolStripButton;
        private ToolStripButton BuscarMarcaEntreDosPreciostoolStripButton;
        private ToolStripButton TallestoolStripButton;
        private ToolStripButton AsignarTalletoolStripButton;
        private ToolStripButton EliminarTalletoolStripButton;
        private ToolStripDropDownButton OrdentoolStripButton;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripMenuItem menorPrecioToolStripMenuItem;
        private ToolStripMenuItem mayorPrecioToolStripMenuItem;
        private ToolStripButton AgregarStocktoolStripButton;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColBrand;
        private DataGridViewTextBoxColumn ColGenre;
        private DataGridViewTextBoxColumn ColSport;
        private DataGridViewTextBoxColumn ColColor;
        private DataGridViewTextBoxColumn ColModelo;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColQuantityInStock;
    }
}