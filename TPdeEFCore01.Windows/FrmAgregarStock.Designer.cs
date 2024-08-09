namespace TPdeEFCore01.Windows
{
    partial class FrmAgregarStock
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
            label1 = new Label();
            StocktextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            TallescomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar1;
            Cancelarbutton.Location = new Point(288, 180);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(123, 54);
            Cancelarbutton.TabIndex = 15;
            Cancelarbutton.Text = "Cancel";
            Cancelarbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok1;
            OKbutton.Location = new Point(75, 180);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(127, 54);
            OKbutton.TabIndex = 14;
            OKbutton.Text = "Ok";
            OKbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 40);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Stock:";
            // 
            // StocktextBox
            // 
            StocktextBox.Location = new Point(75, 37);
            StocktextBox.Name = "StocktextBox";
            StocktextBox.Size = new Size(365, 23);
            StocktextBox.TabIndex = 16;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 104);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 17;
            label2.Text = "Talle:";
            // 
            // TallescomboBox
            // 
            TallescomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TallescomboBox.FormattingEnabled = true;
            TallescomboBox.Location = new Point(73, 106);
            TallescomboBox.Name = "TallescomboBox";
            TallescomboBox.Size = new Size(367, 23);
            TallescomboBox.TabIndex = 18;
            TallescomboBox.SelectedIndexChanged += TallescomboBox_SelectedIndexChanged;
            // 
            // FrmAgregarStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 268);
            ControlBox = false;
            Controls.Add(TallescomboBox);
            Controls.Add(label2);
            Controls.Add(StocktextBox);
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(label1);
            Name = "FrmAgregarStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarStock";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private Label label1;
        private TextBox StocktextBox;
        private ErrorProvider errorProvider1;
        private ComboBox TallescomboBox;
        private Label label2;
    }
}