namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChangeRegion_Btn = new Button();
            Saat = new Label();
            Sekil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Sekil).BeginInit();
            SuspendLayout();
            // 
            // ChangeRegion_Btn
            // 
            ChangeRegion_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChangeRegion_Btn.Location = new Point(-2, -1);
            ChangeRegion_Btn.Name = "ChangeRegion_Btn";
            ChangeRegion_Btn.Size = new Size(245, 74);
            ChangeRegion_Btn.TabIndex = 1;
            ChangeRegion_Btn.Text = "Baku";
            ChangeRegion_Btn.UseVisualStyleBackColor = true;
            ChangeRegion_Btn.Click += ChangeRegion_A;
            // 
            // Saat
            // 
            Saat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Saat.AutoSize = true;
            Saat.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Saat.Location = new Point(622, 32);
            Saat.Name = "Saat";
            Saat.Size = new Size(82, 41);
            Saat.TabIndex = 2;
            Saat.Text = "Baku\r\n";
            // 
            // Sekil
            // 
            Sekil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Sekil.BackgroundImageLayout = ImageLayout.None;
            Sekil.Image = Properties.Resources.Baku;
            Sekil.Location = new Point(-2, 99);
            Sekil.Name = "Sekil";
            Sekil.Size = new Size(954, 446);
            Sekil.SizeMode = PictureBoxSizeMode.StretchImage;
            Sekil.TabIndex = 3;
            Sekil.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 458);
            Controls.Add(Sekil);
            Controls.Add(Saat);
            Controls.Add(ChangeRegion_Btn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Sekil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ChangeRegion_Btn;
        private Label Saat;
        private PictureBox Sekil;
    }
}
