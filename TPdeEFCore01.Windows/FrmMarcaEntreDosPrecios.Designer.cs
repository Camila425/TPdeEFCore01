namespace TPdeEFCore01.Windows
{
    partial class FrmMarcaEntreDosPrecios
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
            components = new System.ComponentModel.Container();
            Cancelarbutton = new Button();
            OKbutton = new Button();
            MarcacomboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            PrecioMinimotextBox = new TextBox();
            label3 = new Label();
            PrecioMaximotextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar1;
            Cancelarbutton.Location = new Point(259, 200);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(123, 54);
            Cancelarbutton.TabIndex = 11;
            Cancelarbutton.Text = "Cancel";
            Cancelarbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok1;
            OKbutton.Location = new Point(68, 200);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(127, 54);
            OKbutton.TabIndex = 10;
            OKbutton.Text = "Ok";
            OKbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // MarcacomboBox
            // 
            MarcacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MarcacomboBox.FormattingEnabled = true;
            MarcacomboBox.Location = new Point(78, 22);
            MarcacomboBox.Name = "MarcacomboBox";
            MarcacomboBox.Size = new Size(343, 23);
            MarcacomboBox.TabIndex = 8;
            MarcacomboBox.SelectedIndexChanged += MarcacomboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Prec.Min";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Marca:";
            // 
            // PrecioMinimotextBox
            // 
            PrecioMinimotextBox.Location = new Point(78, 88);
            PrecioMinimotextBox.Name = "PrecioMinimotextBox";
            PrecioMinimotextBox.Size = new Size(343, 23);
            PrecioMinimotextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 133);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 13;
            label3.Text = "Prec.Max";
            // 
            // PrecioMaximotextBox
            // 
            PrecioMaximotextBox.Location = new Point(78, 130);
            PrecioMaximotextBox.Name = "PrecioMaximotextBox";
            PrecioMaximotextBox.Size = new Size(343, 23);
            PrecioMaximotextBox.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMarcaEntreDosPrecios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 277);
            ControlBox = false;
            Controls.Add(PrecioMaximotextBox);
            Controls.Add(label3);
            Controls.Add(PrecioMinimotextBox);
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(MarcacomboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMarcaEntreDosPrecios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMarcaEntreDosPrecios";
            Load += FrmMarcaEntreDosPrecios_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private ComboBox MarcacomboBox;
        private Label label2;
        private Label label1;
        private TextBox PrecioMinimotextBox;
        private Label label3;
        private TextBox PrecioMaximotextBox;
        private ErrorProvider errorProvider1;
    }
}