namespace Hızlı_Okuma_Uygulaması
{
    partial class KayıtlıMetinler
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
            this.components = new System.ComponentModel.Container();
            this.dataGridMetinler = new System.Windows.Forms.DataGridView();
            this.MetinTextBox = new System.Windows.Forms.TextBox();
            this.BaslikTextBox = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.baslat = new System.Windows.Forms.Button();
            this.okumatimer = new System.Windows.Forms.Timer(this.components);
            this.HizComboBox = new System.Windows.Forms.ComboBox();
            this.txtGenislik = new System.Windows.Forms.TextBox();
            this.lblgenislik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.cbtür = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndüzenle = new System.Windows.Forms.Button();
            this.lblkategoriid = new System.Windows.Forms.Label();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMetinler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMetinler
            // 
            this.dataGridMetinler.AllowUserToAddRows = false;
            this.dataGridMetinler.AllowUserToDeleteRows = false;
            this.dataGridMetinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMetinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMetinler.Location = new System.Drawing.Point(12, 40);
            this.dataGridMetinler.Name = "dataGridMetinler";
            this.dataGridMetinler.ReadOnly = true;
            this.dataGridMetinler.RowHeadersWidth = 51;
            this.dataGridMetinler.RowTemplate.Height = 24;
            this.dataGridMetinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMetinler.Size = new System.Drawing.Size(510, 556);
            this.dataGridMetinler.TabIndex = 0;
            this.dataGridMetinler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMetinler_CellEnter);
            // 
            // MetinTextBox
            // 
            this.MetinTextBox.Location = new System.Drawing.Point(542, 68);
            this.MetinTextBox.Multiline = true;
            this.MetinTextBox.Name = "MetinTextBox";
            this.MetinTextBox.Size = new System.Drawing.Size(421, 452);
            this.MetinTextBox.TabIndex = 5;
            // 
            // BaslikTextBox
            // 
            this.BaslikTextBox.Location = new System.Drawing.Point(542, 40);
            this.BaslikTextBox.Name = "BaslikTextBox";
            this.BaslikTextBox.Size = new System.Drawing.Size(421, 22);
            this.BaslikTextBox.TabIndex = 6;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(542, 527);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(102, 40);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(700, 527);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(102, 40);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(861, 527);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(102, 40);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // baslat
            // 
            this.baslat.Location = new System.Drawing.Point(861, 593);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(102, 24);
            this.baslat.TabIndex = 10;
            this.baslat.Text = "Baslat";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // okumatimer
            // 
            this.okumatimer.Tick += new System.EventHandler(this.kmtimerolayi);
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
            this.HizComboBox.Location = new System.Drawing.Point(574, 593);
            this.HizComboBox.Name = "HizComboBox";
            this.HizComboBox.Size = new System.Drawing.Size(98, 24);
            this.HizComboBox.TabIndex = 11;
            // 
            // txtGenislik
            // 
            this.txtGenislik.Location = new System.Drawing.Point(742, 595);
            this.txtGenislik.Name = "txtGenislik";
            this.txtGenislik.Size = new System.Drawing.Size(113, 22);
            this.txtGenislik.TabIndex = 12;
            // 
            // lblgenislik
            // 
            this.lblgenislik.AutoSize = true;
            this.lblgenislik.Location = new System.Drawing.Point(678, 598);
            this.lblgenislik.Name = "lblgenislik";
            this.lblgenislik.Size = new System.Drawing.Size(58, 16);
            this.lblgenislik.TabIndex = 14;
            this.lblgenislik.Text = "Genişlik:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hız:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(919, 494);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(37, 16);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "label";
            // 
            // cbtür
            // 
            this.cbtür.FormattingEnabled = true;
            this.cbtür.Items.AddRange(new object[] {
            "Hepsi"});
            this.cbtür.Location = new System.Drawing.Point(73, 11);
            this.cbtür.Name = "cbtür";
            this.cbtür.Size = new System.Drawing.Size(327, 24);
            this.cbtür.TabIndex = 18;
            this.cbtür.SelectedIndexChanged += new System.EventHandler(this.cbtür_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kategori:";
            // 
            // btndüzenle
            // 
            this.btndüzenle.Location = new System.Drawing.Point(406, 11);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(116, 23);
            this.btndüzenle.TabIndex = 20;
            this.btndüzenle.Text = "Düzenle";
            this.btndüzenle.UseVisualStyleBackColor = true;
            this.btndüzenle.Click += new System.EventHandler(this.kategoridüzenle);
            // 
            // lblkategoriid
            // 
            this.lblkategoriid.AutoSize = true;
            this.lblkategoriid.Location = new System.Drawing.Point(876, 494);
            this.lblkategoriid.Name = "lblkategoriid";
            this.lblkategoriid.Size = new System.Drawing.Size(37, 16);
            this.lblkategoriid.TabIndex = 22;
            this.lblkategoriid.Text = "label";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(542, 10);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(421, 24);
            this.cbkategori.TabIndex = 23;
            this.cbkategori.SelectedIndexChanged += new System.EventHandler(this.cbkategori_SelectedIndexChanged);
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(12, 603);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(75, 23);
            this.yenile.TabIndex = 24;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // KayıtlıMetinler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 636);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.lblkategoriid);
            this.Controls.Add(this.btndüzenle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtür);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblgenislik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenislik);
            this.Controls.Add(this.HizComboBox);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.BaslikTextBox);
            this.Controls.Add(this.MetinTextBox);
            this.Controls.Add(this.dataGridMetinler);
            this.Name = "KayıtlıMetinler";
            this.Text = "KayıtlıMetinler";
            this.Load += new System.EventHandler(this.KayıtlıMetinler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMetinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMetinler;
        private System.Windows.Forms.TextBox MetinTextBox;
        private System.Windows.Forms.TextBox BaslikTextBox;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Timer okumatimer;
        private System.Windows.Forms.ComboBox HizComboBox;
        private System.Windows.Forms.TextBox txtGenislik;
        private System.Windows.Forms.Label lblgenislik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cbtür;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.Label lblkategoriid;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Button yenile;
    }
}