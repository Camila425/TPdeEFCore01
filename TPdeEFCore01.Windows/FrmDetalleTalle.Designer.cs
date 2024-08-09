namespace TPdeEFCore01.Windows
{
    partial class FrmDetalleTalle
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
            splitContainer1 = new SplitContainer();
            toolStrip1 = new ToolStrip();
            DatosdataGridView = new DataGridView();
            coltalle = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(DatosdataGridView);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 65;
            splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // DatosdataGridView
            // 
            DatosdataGridView.AllowUserToAddRows = false;
            DatosdataGridView.AllowUserToDeleteRows = false;
            DatosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosdataGridView.Columns.AddRange(new DataGridViewColumn[] { coltalle, colStock });
            DatosdataGridView.Dock = DockStyle.Top;
            DatosdataGridView.Location = new Point(0, 0);
            DatosdataGridView.Name = "DatosdataGridView";
            DatosdataGridView.ReadOnly = true;
            DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosdataGridView.Size = new Size(800, 305);
            DatosdataGridView.TabIndex = 0;
            // 
            // coltalle
            // 
            coltalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coltalle.HeaderText = "Talle";
            coltalle.Name = "coltalle";
            coltalle.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // FrmDetalleTalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmDetalleTalle";
            Text = "FrmDetalleTalles";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DatosdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private DataGridView DatosdataGridView;
        private DataGridViewTextBoxColumn coltalle;
        private DataGridViewTextBoxColumn colStock;
    }
}