namespace TPdeEFCore01.Windows
{
    partial class FrmShoeAE
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
            DescripciontextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ModelotextBox = new TextBox();
            label3 = new Label();
            PreciotextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            MarcacomboBox = new ComboBox();
            label4 = new Label();
            ColorcomboBox = new ComboBox();
            GenerocomboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            DeportecomboBox = new ComboBox();
            label7 = new Label();
            NuevaMarcaabel = new Label();
            NuevoGenerolabel = new Label();
            NuevoDeportelabel = new Label();
            NuevoColorlabel = new Label();
            AgregarNuevaMarcabutton = new Button();
            AgregarUnNuevoGenerobutton = new Button();
            AgregarUnNuevoDeportebutton = new Button();
            AgregarUnNuevoColorbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar;
            Cancelarbutton.Location = new Point(276, 456);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(126, 53);
            Cancelarbutton.TabIndex = 11;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok;
            OKbutton.Location = new Point(89, 456);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(126, 53);
            OKbutton.TabIndex = 10;
            OKbutton.Text = "OK";
            OKbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // DescripciontextBox
            // 
            DescripciontextBox.Location = new Point(89, 25);
            DescripciontextBox.Name = "DescripciontextBox";
            DescripciontextBox.Size = new Size(313, 23);
            DescripciontextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 8;
            label1.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Modelo:";
            // 
            // ModelotextBox
            // 
            ModelotextBox.Location = new Point(89, 69);
            ModelotextBox.Name = "ModelotextBox";
            ModelotextBox.Size = new Size(313, 23);
            ModelotextBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 116);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Precio:";
            // 
            // PreciotextBox
            // 
            PreciotextBox.Location = new Point(89, 116);
            PreciotextBox.Name = "PreciotextBox";
            PreciotextBox.Size = new Size(313, 23);
            PreciotextBox.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MarcacomboBox
            // 
            MarcacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MarcacomboBox.FormattingEnabled = true;
            MarcacomboBox.Location = new Point(89, 182);
            MarcacomboBox.Name = "MarcacomboBox";
            MarcacomboBox.Size = new Size(313, 23);
            MarcacomboBox.TabIndex = 16;
            MarcacomboBox.SelectedIndexChanged += MarcacomboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 182);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 17;
            label4.Text = "Marca:";
            // 
            // ColorcomboBox
            // 
            ColorcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorcomboBox.FormattingEnabled = true;
            ColorcomboBox.Location = new Point(89, 383);
            ColorcomboBox.Name = "ColorcomboBox";
            ColorcomboBox.Size = new Size(313, 23);
            ColorcomboBox.TabIndex = 18;
            ColorcomboBox.SelectedIndexChanged += ColorcomboBox_SelectedIndexChanged;
            // 
            // GenerocomboBox
            // 
            GenerocomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenerocomboBox.FormattingEnabled = true;
            GenerocomboBox.Location = new Point(89, 253);
            GenerocomboBox.Name = "GenerocomboBox";
            GenerocomboBox.Size = new Size(313, 23);
            GenerocomboBox.TabIndex = 19;
            GenerocomboBox.SelectedIndexChanged += GenerocomboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 256);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 20;
            label5.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 319);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 21;
            label6.Text = "Deporte:";
            // 
            // DeportecomboBox
            // 
            DeportecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeportecomboBox.FormattingEnabled = true;
            DeportecomboBox.Location = new Point(89, 319);
            DeportecomboBox.Name = "DeportecomboBox";
            DeportecomboBox.Size = new Size(313, 23);
            DeportecomboBox.TabIndex = 22;
            DeportecomboBox.SelectedIndexChanged += DeportecomboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 391);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 23;
            label7.Text = "Color:";
            // 
            // NuevaMarcaabel
            // 
            NuevaMarcaabel.AutoSize = true;
            NuevaMarcaabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevaMarcaabel.ForeColor = Color.Red;
            NuevaMarcaabel.Location = new Point(89, 164);
            NuevaMarcaabel.Name = "NuevaMarcaabel";
            NuevaMarcaabel.Size = new Size(80, 15);
            NuevaMarcaabel.TabIndex = 24;
            NuevaMarcaabel.Text = "Nueva Marca";
            NuevaMarcaabel.Visible = false;
            // 
            // NuevoGenerolabel
            // 
            NuevoGenerolabel.AutoSize = true;
            NuevoGenerolabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoGenerolabel.ForeColor = Color.Red;
            NuevoGenerolabel.Location = new Point(89, 230);
            NuevoGenerolabel.Name = "NuevoGenerolabel";
            NuevoGenerolabel.Size = new Size(89, 15);
            NuevoGenerolabel.TabIndex = 25;
            NuevoGenerolabel.Text = "Nuevo Genero";
            NuevoGenerolabel.Visible = false;
            // 
            // NuevoDeportelabel
            // 
            NuevoDeportelabel.AutoSize = true;
            NuevoDeportelabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoDeportelabel.ForeColor = Color.Red;
            NuevoDeportelabel.Location = new Point(89, 301);
            NuevoDeportelabel.Name = "NuevoDeportelabel";
            NuevoDeportelabel.Size = new Size(94, 15);
            NuevoDeportelabel.TabIndex = 26;
            NuevoDeportelabel.Text = "Nuevo Deporte";
            NuevoDeportelabel.Visible = false;
            // 
            // NuevoColorlabel
            // 
            NuevoColorlabel.AutoSize = true;
            NuevoColorlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NuevoColorlabel.ForeColor = Color.Red;
            NuevoColorlabel.Location = new Point(89, 365);
            NuevoColorlabel.Name = "NuevoColorlabel";
            NuevoColorlabel.Size = new Size(76, 15);
            NuevoColorlabel.TabIndex = 27;
            NuevoColorlabel.Text = "Nuevo Color";
            NuevoColorlabel.Visible = false;
            // 
            // AgregarNuevaMarcabutton
            // 
            AgregarNuevaMarcabutton.Image = Properties.Resources.create_36px;
            AgregarNuevaMarcabutton.Location = new Point(420, 164);
            AgregarNuevaMarcabutton.Name = "AgregarNuevaMarcabutton";
            AgregarNuevaMarcabutton.Size = new Size(42, 52);
            AgregarNuevaMarcabutton.TabIndex = 28;
            AgregarNuevaMarcabutton.UseVisualStyleBackColor = true;
            AgregarNuevaMarcabutton.Click += AgregarNuevaMarcabutton_Click;
            // 
            // AgregarUnNuevoGenerobutton
            // 
            AgregarUnNuevoGenerobutton.Image = Properties.Resources.create_36px;
            AgregarUnNuevoGenerobutton.Location = new Point(420, 237);
            AgregarUnNuevoGenerobutton.Name = "AgregarUnNuevoGenerobutton";
            AgregarUnNuevoGenerobutton.Size = new Size(42, 52);
            AgregarUnNuevoGenerobutton.TabIndex = 29;
            AgregarUnNuevoGenerobutton.UseVisualStyleBackColor = true;
            AgregarUnNuevoGenerobutton.Click += AgregarUnNuevoGenerobutton_Click;
            // 
            // AgregarUnNuevoDeportebutton
            // 
            AgregarUnNuevoDeportebutton.Image = Properties.Resources.create_36px;
            AgregarUnNuevoDeportebutton.Location = new Point(420, 303);
            AgregarUnNuevoDeportebutton.Name = "AgregarUnNuevoDeportebutton";
            AgregarUnNuevoDeportebutton.Size = new Size(42, 52);
            AgregarUnNuevoDeportebutton.TabIndex = 30;
            AgregarUnNuevoDeportebutton.UseVisualStyleBackColor = true;
            AgregarUnNuevoDeportebutton.Click += AgregarUnNuevoDeportebutton_Click;
            // 
            // AgregarUnNuevoColorbutton
            // 
            AgregarUnNuevoColorbutton.Image = Properties.Resources.create_36px;
            AgregarUnNuevoColorbutton.Location = new Point(420, 372);
            AgregarUnNuevoColorbutton.Name = "AgregarUnNuevoColorbutton";
            AgregarUnNuevoColorbutton.Size = new Size(42, 52);
            AgregarUnNuevoColorbutton.TabIndex = 31;
            AgregarUnNuevoColorbutton.UseVisualStyleBackColor = true;
            AgregarUnNuevoColorbutton.Click += AgregarUnNuevoColorbutton_Click;
            // 
            // FrmShoeAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 515);
            ControlBox = false;
            Controls.Add(AgregarUnNuevoColorbutton);
            Controls.Add(AgregarUnNuevoDeportebutton);
            Controls.Add(AgregarUnNuevoGenerobutton);
            Controls.Add(AgregarNuevaMarcabutton);
            Controls.Add(NuevoColorlabel);
            Controls.Add(NuevoDeportelabel);
            Controls.Add(NuevoGenerolabel);
            Controls.Add(NuevaMarcaabel);
            Controls.Add(label7);
            Controls.Add(DeportecomboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(GenerocomboBox);
            Controls.Add(ColorcomboBox);
            Controls.Add(label4);
            Controls.Add(MarcacomboBox);
            Controls.Add(PreciotextBox);
            Controls.Add(label3);
            Controls.Add(ModelotextBox);
            Controls.Add(label2);
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(DescripciontextBox);
            Controls.Add(label1);
            Name = "FrmShoeAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmShoeAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private TextBox DescripciontextBox;
        private Label label1;
        private Label label2;
        private TextBox ModelotextBox;
        private Label label3;
        private TextBox PreciotextBox;
        private ErrorProvider errorProvider1;
        private ComboBox DeportecomboBox;
        private Label label6;
        private Label label5;
        private ComboBox GenerocomboBox;
        private ComboBox ColorcomboBox;
        private Label label4;
        private ComboBox MarcacomboBox;
        private Label NuevoGenerolabel;
        private Label NuevaMarcaabel;
        private Label label7;
        private Label NuevoColorlabel;
        private Label NuevoDeportelabel;
        private Button AgregarUnNuevoColorbutton;
        private Button AgregarUnNuevoDeportebutton;
        private Button AgregarUnNuevoGenerobutton;
        private Button AgregarNuevaMarcabutton;
    }
}