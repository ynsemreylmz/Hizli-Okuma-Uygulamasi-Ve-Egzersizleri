namespace Hızlı_Okuma_Uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnYardim = new System.Windows.Forms.Button();
            this.HizComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnaTextBox = new System.Windows.Forms.TextBox();
            this.okumatimer = new System.Windows.Forms.Timer(this.components);
            this.lblgenislik = new System.Windows.Forms.Label();
            this.txtGenislik = new System.Windows.Forms.TextBox();
            this.btnmetinler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(246, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(92, 24);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Basla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.OkumayaBasla);
            // 
            // btnYardim
            // 
            this.btnYardim.Location = new System.Drawing.Point(460, 12);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(79, 24);
            this.btnYardim.TabIndex = 1;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.YardımıGoster);
            // 
            // HizComboBox
            // 
            this.HizComboBox.FormattingEnabled = true;
            this.HizComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.HizComboBox.Location = new System.Drawing.Point(41, 12);
            this.HizComboBox.Name = "HizComboBox";
            this.HizComboBox.Size = new System.Drawing.Size(70, 24);
            this.HizComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hız:";
            // 
            // AnaTextBox
            // 
            this.AnaTextBox.Location = new System.Drawing.Point(12, 49);
            this.AnaTextBox.Multiline = true;
            this.AnaTextBox.Name = "AnaTextBox";
            this.AnaTextBox.Size = new System.Drawing.Size(526, 499);
            this.AnaTextBox.TabIndex = 4;
            // 
            // okumatimer
            // 
            this.okumatimer.Tick += new System.EventHandler(this.OkumaTimerOlayı);
            // 
            // lblgenislik
            // 
            this.lblgenislik.AutoSize = true;
            this.lblgenislik.Location = new System.Drawing.Point(117, 15);
            this.lblgenislik.Name = "lblgenislik";
            this.lblgenislik.Size = new System.Drawing.Size(58, 16);
            this.lblgenislik.TabIndex = 5;
            this.lblgenislik.Text = "Genişlik:";
            // 
            // txtGenislik
            // 
            this.txtGenislik.Location = new System.Drawing.Point(172, 12);
            this.txtGenislik.Name = "txtGenislik";
            this.txtGenislik.Size = new System.Drawing.Size(68, 22);
            this.txtGenislik.TabIndex = 6;
            // 
            // btnmetinler
            // 
            this.btnmetinler.Location = new System.Drawing.Point(344, 13);
            this.btnmetinler.Name = "btnmetinler";
            this.btnmetinler.Size = new System.Drawing.Size(110, 23);
            this.btnmetinler.TabIndex = 7;
            this.btnmetinler.Text = "Metinler";
            this.btnmetinler.UseVisualStyleBackColor = true;
            this.btnmetinler.Click += new System.EventHandler(this.kayıtlımetinler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 604);
            this.Controls.Add(this.btnmetinler);
            this.Controls.Add(this.txtGenislik);
            this.Controls.Add(this.lblgenislik);
            this.Controls.Add(this.AnaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HizComboBox);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Okuma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnYardim;
        private System.Windows.Forms.ComboBox HizComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnaTextBox;
        private System.Windows.Forms.Timer okumatimer;
        private System.Windows.Forms.Label lblgenislik;
        private System.Windows.Forms.TextBox txtGenislik;
        private System.Windows.Forms.Button btnmetinler;
    }
}

