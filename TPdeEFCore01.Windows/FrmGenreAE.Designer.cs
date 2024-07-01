namespace TPdeEFCore01.Windows
{
    partial class FrmGenreAE
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
            GenretextBox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar;
            Cancelarbutton.Location = new Point(267, 113);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(126, 53);
            Cancelarbutton.TabIndex = 7;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok;
            OKbutton.Location = new Point(55, 113);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(126, 53);
            OKbutton.TabIndex = 6;
            OKbutton.Text = "OK";
            OKbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // GenretextBox
            // 
            GenretextBox.Location = new Point(109, 25);
            GenretextBox.Name = "GenretextBox";
            GenretextBox.Size = new Size(313, 23);
            GenretextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Genero:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmGenreAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 193);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(GenretextBox);
            Controls.Add(label1);
            Name = "FrmGenreAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGenreAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private TextBox GenretextBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}