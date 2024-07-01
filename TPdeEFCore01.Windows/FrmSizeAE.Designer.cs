namespace TPdeEFCore01.Windows
{
    partial class FrmSizeAE
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
            TalletextBox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar;
            Cancelarbutton.Location = new Point(283, 104);
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
            OKbutton.Location = new Point(62, 104);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(126, 53);
            OKbutton.TabIndex = 10;
            OKbutton.Text = "OK";
            OKbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // TalletextBox
            // 
            TalletextBox.Location = new Point(62, 30);
            TalletextBox.Name = "TalletextBox";
            TalletextBox.Size = new Size(347, 23);
            TalletextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "Talle:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmSizeAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 186);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(TalletextBox);
            Controls.Add(label1);
            Name = "FrmSizeAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSizeAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private TextBox TalletextBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}