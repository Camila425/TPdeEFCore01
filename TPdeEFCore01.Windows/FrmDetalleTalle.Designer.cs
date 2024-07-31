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
            DatosdataGridView = new DataGridView();
            ColTalle = new DataGridViewTextBoxColumn();
            colstock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DatosdataGridView).BeginInit();
            SuspendLayout();
            // 
            // DatosdataGridView
            // 
            DatosdataGridView.AllowUserToAddRows = false;
            DatosdataGridView.AllowUserToDeleteRows = false;
            DatosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosdataGridView.Columns.AddRange(new DataGridViewColumn[] { ColTalle, colstock });
            DatosdataGridView.Dock = DockStyle.Fill;
            DatosdataGridView.Location = new Point(0, 0);
            DatosdataGridView.Name = "DatosdataGridView";
            DatosdataGridView.ReadOnly = true;
            DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosdataGridView.Size = new Size(800, 450);
            DatosdataGridView.TabIndex = 0;
            // 
            // ColTalle
            // 
            ColTalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTalle.HeaderText = "Talle";
            ColTalle.Name = "ColTalle";
            ColTalle.ReadOnly = true;
            // 
            // colstock
            // 
            colstock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colstock.HeaderText = "Stock";
            colstock.Name = "colstock";
            colstock.ReadOnly = true;
            // 
            // FrmDetalleTalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DatosdataGridView);
            Name = "FrmDetalleTalle";
            Text = "FrmDetalleTalles";
            ((System.ComponentModel.ISupportInitialize)DatosdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DatosdataGridView;
        private DataGridViewTextBoxColumn ColTalle;
        private DataGridViewTextBoxColumn colstock;
    }
}