namespace TPdeEFCore01.Windows
{
    partial class FrmGeneroYDeporte
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
            DeportecomboBox = new ComboBox();
            GenerocomboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar1;
            Cancelarbutton.Location = new Point(266, 129);
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
            OKbutton.Location = new Point(61, 129);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(127, 54);
            OKbutton.TabIndex = 10;
            OKbutton.Text = "Ok";
            OKbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // DeportecomboBox
            // 
            DeportecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeportecomboBox.FormattingEnabled = true;
            DeportecomboBox.Location = new Point(87, 73);
            DeportecomboBox.Name = "DeportecomboBox";
            DeportecomboBox.Size = new Size(337, 23);
            DeportecomboBox.TabIndex = 9;
            DeportecomboBox.SelectedIndexChanged += DeportecomboBox_SelectedIndexChanged;
            // 
            // GenerocomboBox
            // 
            GenerocomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenerocomboBox.FormattingEnabled = true;
            GenerocomboBox.Location = new Point(81, 12);
            GenerocomboBox.Name = "GenerocomboBox";
            GenerocomboBox.Size = new Size(343, 23);
            GenerocomboBox.TabIndex = 8;
            GenerocomboBox.SelectedIndexChanged += GenerocomboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Deporte:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Genero:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmGeneroYDeporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 202);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(DeportecomboBox);
            Controls.Add(GenerocomboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGeneroYDeporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGeneroYDeporte";
            Load += FrmGeneroYDeporte_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private ComboBox DeportecomboBox;
        private ComboBox GenerocomboBox;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}