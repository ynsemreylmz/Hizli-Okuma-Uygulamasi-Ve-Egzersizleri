namespace Hızlı_Okuma_Uygulaması
{
    partial class KategoriDüzenle
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
            this.dataGridMetinler = new System.Windows.Forms.DataGridView();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.btngncl = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
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
            this.dataGridMetinler.Location = new System.Drawing.Point(12, 12);
            this.dataGridMetinler.Name = "dataGridMetinler";
            this.dataGridMetinler.ReadOnly = true;
            this.dataGridMetinler.RowHeadersWidth = 51;
            this.dataGridMetinler.RowTemplate.Height = 24;
            this.dataGridMetinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMetinler.Size = new System.Drawing.Size(241, 405);
            this.dataGridMetinler.TabIndex = 1;
            this.dataGridMetinler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMetinler_CellEnter);
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(259, 12);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(197, 22);
            this.txtkategori.TabIndex = 2;
            // 
            // btngncl
            // 
            this.btngncl.Location = new System.Drawing.Point(259, 57);
            this.btngncl.Name = "btngncl";
            this.btngncl.Size = new System.Drawing.Size(197, 45);
            this.btngncl.TabIndex = 3;
            this.btngncl.Text = "Güncelle";
            this.btngncl.UseVisualStyleBackColor = true;
            this.btngncl.Click += new System.EventHandler(this.btngncl_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(259, 108);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(197, 45);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(259, 159);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(197, 45);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(412, 217);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "label1";
            this.lblid.Visible = false;
            // 
            // yenile
            // 
            this.yenile.Location = new System.Drawing.Point(12, 424);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(75, 23);
            this.yenile.TabIndex = 7;
            this.yenile.Text = "yenile";
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // KategoriDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 456);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btngncl);
            this.Controls.Add(this.txtkategori);
            this.Controls.Add(this.dataGridMetinler);
            this.Name = "KategoriDüzenle";
            this.Text = "KategoriDüzenle";
            this.Load += new System.EventHandler(this.KategoriDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMetinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMetinler;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Button btngncl;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button yenile;
    }
}