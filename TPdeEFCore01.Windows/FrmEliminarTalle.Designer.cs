namespace TPdeEFCore01.Windows
{
    partial class FrmEliminarTalle
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
            TallesComboBox = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar1;
            Cancelarbutton.Location = new Point(311, 103);
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
            OKbutton.Location = new Point(91, 103);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(127, 54);
            OKbutton.TabIndex = 14;
            OKbutton.Text = "Ok";
            OKbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // TallesComboBox
            // 
            TallesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TallesComboBox.FormattingEnabled = true;
            TallesComboBox.Location = new Point(91, 29);
            TallesComboBox.Name = "TallesComboBox";
            TallesComboBox.Size = new Size(343, 23);
            TallesComboBox.TabIndex = 13;
            TallesComboBox.SelectedIndexChanged += TallesComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 12;
            label1.Text = "Talle:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmEliminarTalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 180);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(TallesComboBox);
            Controls.Add(label1);
            Name = "FrmEliminarTalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEliminarTalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private ComboBox TallesComboBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}