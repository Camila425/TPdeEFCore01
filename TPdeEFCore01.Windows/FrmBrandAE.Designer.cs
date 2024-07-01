namespace TPdeEFCore01.Windows
{
    partial class FrmBrandAE
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
            MarcatextBox = new TextBox();
            OKbutton = new Button();
            Cancelarbutton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // MarcatextBox
            // 
            MarcatextBox.Location = new Point(100, 39);
            MarcatextBox.Name = "MarcatextBox";
            MarcatextBox.Size = new Size(313, 23);
            MarcatextBox.TabIndex = 1;
            // 
            // OKbutton
            // 
            OKbutton.Image = Properties.Resources.ok;
            OKbutton.Location = new Point(46, 127);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(126, 53);
            OKbutton.TabIndex = 2;
            OKbutton.Text = "OK";
            OKbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar;
            Cancelarbutton.Location = new Point(258, 127);
            Cancelarbutton.Name = "Cancelarbutton";
            Cancelarbutton.Size = new Size(126, 53);
            Cancelarbutton.TabIndex = 3;
            Cancelarbutton.Text = "Cancelar";
            Cancelarbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            Cancelarbutton.UseVisualStyleBackColor = true;
            Cancelarbutton.Click += Cancelarbutton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmBrandAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 192);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(MarcatextBox);
            Controls.Add(label1);
            Name = "FrmBrandAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBrandAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MarcatextBox;
        private Button OKbutton;
        private Button Cancelarbutton;
        private ErrorProvider errorProvider1;
    }
}