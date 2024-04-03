namespace Bankacilik_sifre_giris_sistemi
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
            txtSifreGiris = new TextBox();
            lblParola = new Label();
            SuspendLayout();
            // 
            // txtSifreGiris
            // 
            txtSifreGiris.Location = new Point(185, 126);
            txtSifreGiris.Margin = new Padding(4);
            txtSifreGiris.MaxLength = 3471;
            txtSifreGiris.Name = "txtSifreGiris";
            txtSifreGiris.Size = new Size(306, 31);
            txtSifreGiris.TabIndex = 0;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = SystemColors.ButtonHighlight;
            lblParola.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblParola.Location = new Point(102, 129);
            lblParola.Margin = new Padding(4, 0, 4, 0);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(75, 28);
            lblParola.TabIndex = 1;
            lblParola.Text = " Parola:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(637, 537);
            Controls.Add(lblParola);
            Controls.Add(txtSifreGiris);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Banka Şifre Girişi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifreGiris;
        private Label lblParola;
    }
}
