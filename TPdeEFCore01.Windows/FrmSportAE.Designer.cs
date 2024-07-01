namespace TPdeEFCore01.Windows
{
    partial class FrmSportAE
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
            SporttextBox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Cancelarbutton
            // 
            Cancelarbutton.Image = Properties.Resources.cancelar;
            Cancelarbutton.Location = new Point(259, 112);
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
            OKbutton.Location = new Point(47, 112);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(126, 53);
            OKbutton.TabIndex = 10;
            OKbutton.Text = "OK";
            OKbutton.TextImageRelation = TextImageRelation.TextBeforeImage;
            OKbutton.UseVisualStyleBackColor = true;
            OKbutton.Click += OKbutton_Click;
            // 
            // SporttextBox
            // 
            SporttextBox.Location = new Point(101, 24);
            SporttextBox.Name = "SporttextBox";
            SporttextBox.Size = new Size(313, 23);
            SporttextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 8;
            label1.Text = "Sport";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmSportAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 198);
            ControlBox = false;
            Controls.Add(Cancelarbutton);
            Controls.Add(OKbutton);
            Controls.Add(SporttextBox);
            Controls.Add(label1);
            Name = "FrmSportAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSportAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelarbutton;
        private Button OKbutton;
        private TextBox SporttextBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}