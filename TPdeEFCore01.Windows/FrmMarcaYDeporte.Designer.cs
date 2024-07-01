namespace TPdeEFCore01.Windows
{
    partial class FrmMarcaYDeporte
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
            label1 = new Label();
            label2 = new Label();
            MarcacomboBox = new ComboBox();
            DeportecomboBox = new ComboBox();
            OKbutton = new Button();
            Cancelarbutton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Deporte:";
            // 
            // MarcacomboBox
            // 
            MarcacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MarcacomboBox.FormattingEnabled = true;
            MarcacomboBox.Location = new Point(90, 26);
            MarcacomboBox.Name = "MarcacomboBox";
            MarcacomboBox.Size = new Size(343, 23);
            MarcacomboBox.TabIndex = 2;
            MarcacomboBox.SelectedIndexChanged += MarcacomboBox_SelectedIndexChanged;
            // 
            // DeportecomboBox
            // 
            DeportecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeportecomboBox.FormattingEnabled = true;
            DeportecomboBox.Location = new Point(96, 87);
            DeportecomboBox.Name = "DeportecomboBox";
            DeportecomboBox.Size = new Size(337, 23);
            DeportecomboBox.TabIndex = 3;
            DeportecomboBox.SelectedIndexChanged += DeportecomboBox_SelectedIndexChanged;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok1;
            OKbutton.Location = new Point(70, 143);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(127, 54);
            OKbutton.TabIndex = 4;
            OKbutton.Text = "Ok";
            OKbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar1;
            Cancelarbutton.Location = new Point(275, 143);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(123, 54);
            Cancelarbutton.TabIndex = 5;
            Cancelarbutton.Text = "Cancel";
            Cancelarbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMarcaYDeporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 212);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(DeportecomboBox);
            Controls.Add(MarcacomboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMarcaYDeporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMarcaYDeporte";
            Load += FrmMarcaYDeporte_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MarcacomboBox;
        private ComboBox DeportecomboBox;
        private Button OKbutton;
        private Button Cancelarbutton;
        private ErrorProvider errorProvider1;
    }
}