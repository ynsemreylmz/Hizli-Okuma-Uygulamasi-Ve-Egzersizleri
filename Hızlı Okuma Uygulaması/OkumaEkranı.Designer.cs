namespace Hızlı_Okuma_Uygulaması
{
    partial class OkumaEkranı
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
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKelime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.ForeColor = System.Drawing.Color.Red;
            this.lblKelime.Location = new System.Drawing.Point(-1, 1);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(1074, 590);
            this.lblKelime.TabIndex = 0;
            this.lblKelime.Text = "Hazır Olduğunuzda Baslat Butonuna Basınız";
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDurdur
            // 
            this.btnDurdur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.Location = new System.Drawing.Point(449, 534);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(154, 44);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Baslat";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.DurdurmaOlayı);
            // 
            // OkumaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1074, 590);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.lblKelime);
            this.Name = "OkumaEkranı";
            this.Text = "Okuma Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OkumaEkranıKapama);
            this.Load += new System.EventHandler(this.OkumaEkranıYuklenme);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDurdur;
        internal System.Windows.Forms.Label lblKelime;
    }
}