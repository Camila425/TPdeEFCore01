namespace TPdeEFCore01.Windows
{
    partial class FrmColors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColors));
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            NuevotoolStripButton = new ToolStripButton();
            BorrartoolStripButton = new ToolStripButton();
            EditartoolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            anteriorbutton = new Button();
            Siguientebutton = new Button();
            Ultimobutton = new Button();
            Primerobutton = new Button();
            CantRegistrostextBox = new TextBox();
            label2 = new Label();
            PaginascomboBox = new ComboBox();
            label1 = new Label();
            DatosdataGridView = new DataGridView();
            colColorName = new DataGridViewTextBoxColumn();
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
            splitContainer1.Size = new Size(800, 416);
            splitContainer1.SplitterDistance = 62;
            splitContainer1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { NuevotoolStripButton, BorrartoolStripButton, EditartoolStripButton, toolStripSeparator1, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 58);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 58);
            // 
            // anteriorbutton
            // 
            anteriorbutton.Image = Properties.Resources.previous_48px;
            anteriorbutton.Location = new Point(491, 306);
            anteriorbutton.Name = "anteriorbutton";
            anteriorbutton.Size = new Size(75, 39);
            anteriorbutton.TabIndex = 16;
            anteriorbutton.UseVisualStyleBackColor = true;
            anteriorbutton.Click += anteriorbutton_Click;
            // 
            // Siguientebutton
            // 
            Siguientebutton.Image = Properties.Resources.next_48px;
            Siguientebutton.Location = new Point(590, 306);
            Siguientebutton.Name = "Siguientebutton";
            Siguientebutton.Size = new Size(75, 39);
            Siguientebutton.TabIndex = 15;
            Siguientebutton.UseVisualStyleBackColor = true;
            Siguientebutton.Click += Siguientebutton_Click;
            // 
            // Ultimobutton
            // 
            Ultimobutton.Image = Properties.Resources.last_48px;
            Ultimobutton.Location = new Point(685, 306);
            Ultimobutton.Name = "Ultimobutton";
            Ultimobutton.Size = new Size(75, 39);
            Ultimobutton.TabIndex = 14;
            Ultimobutton.UseVisualStyleBackColor = true;
            Ultimobutton.Click += Ultimobutton_Click;
            // 
            // Primerobutton
            // 
            Primerobutton.Image = Properties.Resources.first_48px;
            Primerobutton.Location = new Point(392, 306);
            Primerobutton.Name = "Primerobutton";
            Primerobutton.Size = new Size(75, 39);
            Primerobutton.TabIndex = 13;
            Primerobutton.UseVisualStyleBackColor = true;
            Primerobutton.Click += Primerobutton_Click;
            // 
            // CantRegistrostextBox
            // 
            CantRegistrostextBox.Location = new Point(136, 315);
            CantRegistrostextBox.Name = "CantRegistrostextBox";
            CantRegistrostextBox.Size = new Size(22, 23);
            CantRegistrostextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 318);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 11;
            label2.Text = "De";
            // 
            // PaginascomboBox
            // 
            PaginascomboBox.FormattingEnabled = true;
            PaginascomboBox.Location = new Point(47, 315);
            PaginascomboBox.Name = "PaginascomboBox";
            PaginascomboBox.Size = new Size(56, 23);
            PaginascomboBox.TabIndex = 10;
            PaginascomboBox.SelectedIndexChanged += PaginascomboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 318);
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
            DatosdataGridView.Columns.AddRange(new DataGridViewColumn[] { colColorName });
            DatosdataGridView.Location = new Point(0, 3);
            DatosdataGridView.Name = "DatosdataGridView";
            DatosdataGridView.ReadOnly = true;
            DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosdataGridView.Size = new Size(800, 297);
            DatosdataGridView.TabIndex = 0;
            // 
            // colColorName
            // 
            colColorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colColorName.HeaderText = "ColorName";
            colColorName.Name = "colColorName";
            colColorName.ReadOnly = true;
            // 
            // FrmColors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(splitContainer1);
            Name = "FrmColors";
            Text = "FrmColors";
            Load += FrmColors_Load;
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
        private DataGridViewTextBoxColumn colColorName;
        private Button anteriorbutton;
        private Button Siguientebutton;
        private Button Ultimobutton;
        private Button Primerobutton;
        private TextBox CantRegistrostextBox;
        private Label label2;
        private ComboBox PaginascomboBox;
        private Label label1;
    }
}