using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hızlı_Okuma_Uygulaması
{
    public partial class KategoriDüzenle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public KategoriDüzenle()
        {
            InitializeComponent();
            dataGridMetinler.BorderStyle = BorderStyle.None;
            

        }
        void kategorigetir()
        {
            baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=hizliokumauygulamasi;Integrated Security=True; Pooling=false;");
            baglanti.Open();
            da = new SqlDataAdapter("select * from kategoriler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridMetinler.DataSource = tablo;
            baglanti.Close();
            this.dataGridMetinler.Columns["kategoriid"].Visible = false;
        }
        private void KategoriDüzenle_Load(object sender, EventArgs e)
        {
            kategorigetir();
         
        }

        private void dataGridMetinler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            lblid.Text = dataGridMetinler.CurrentRow.Cells[0].Value.ToString();
            baglanti.Close();
            txtkategori.Text = dataGridMetinler.CurrentRow.Cells[1].Value.ToString();
            SqlCommand sqlCmd = new SqlCommand("SELECT kategoriid FROM kategoriler where kategori='" + txtkategori.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {


                lblid.Text = sqlReader[0].ToString();

            }

            sqlReader.Close();
            baglanti.Close();
        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutk = new SqlCommand("Select * From kategoriler where kategori=@p1", baglanti);
            komutk.Parameters.AddWithValue("@p1", txtkategori.Text);
            SqlDataReader okuk = komutk.ExecuteReader();
            if (okuk.Read())
            {

                MessageBox.Show(txtkategori.Text+" isimli bir kategori zaten var!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                string sorgu = "update kategoriler set kategori = @kategori where kategoriid = @kategoriid";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kategori", txtkategori.Text);
                komut.Parameters.AddWithValue("@kategoriid", lblid.Text);
               
                komut.ExecuteNonQuery();
                baglanti.Close();
                kategorigetir();
            }
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutk = new SqlCommand("Select * From kategoriler where kategori=@p1", baglanti);
            komutk.Parameters.AddWithValue("@p1", txtkategori.Text);
            SqlDataReader okuk = komutk.ExecuteReader();
           
            if (okuk.Read())
            {

                MessageBox.Show(txtkategori.Text + " isimli bir kategori zaten var!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
           
            else {
            baglanti.Close();
            baglanti.Open();
            string sorgu = "insert into kategoriler(kategori) values (@kategori)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kategori", txtkategori.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            kategorigetir();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string metinbaslik = txtkategori.Text.Trim();
            DialogResult result = MessageBox.Show('"' + metinbaslik + '"' + " kategorisini silmek istediğinize emin misiniz?", "DİKKAT!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    baglanti.Close();
                    string sorgu = "delete from kategoriler where kategoriid=@id";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("id", Convert.ToInt32(lblid.Text));
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    kategorigetir();
                }
                catch
                {
                    MessageBox.Show("Silme işlemi yapılamadı. \n" + '"' + metinbaslik + '"' + " kategorisine kayıtlı metin veya metinler bulunmakta olabilir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
