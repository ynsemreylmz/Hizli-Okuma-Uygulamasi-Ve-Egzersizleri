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
    public partial class KayıtlıMetinler : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        string tür = "Hepsi";
        string kategori;
        string kelimeler;
        string[] ayrılmıs;
        int toplamkelime;
        int sayac = -1;
        int metinsınır;
        int wsayac;
        OkumaEkranı okutucu2;
        bool ikileme = false;
        int yerelsayac;
        char[] ayirmachar = { '*', ',', '.', '-', '+', ' ', '!', '?', '^', '#', '$', ':', ';', '_', '\'', '"', '\\', '/', '(', ')', '~', '<', '>', '|', '{', '}', '[', ']', '&', '=' };
        string temizmetin;

        public KayıtlıMetinler()
        {
           InitializeComponent();
            HizComboBox.Text = "1";
            cbtür.Text = "Hepsi";
            dataGridMetinler.BorderStyle = BorderStyle.None;
           

        }
       

        void MetinGetir()
        {
            if (tür=="Hepsi")
            {
                baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=hizliokumauygulamasi;Integrated Security=True; Pooling=false;");
                baglanti.Open();
                da = new SqlDataAdapter("select id,baslik,metin,kategori from metinler as o inner join kategoriler as b on o.kategoriid = b.kategoriid", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridMetinler.DataSource = tablo;

                
                baglanti.Close();
            }
            else
            {
                baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=hizliokumauygulamasi;Integrated Security=True; Pooling=false;");
                baglanti.Open();
                da = new SqlDataAdapter("select id,baslik,metin,kategori from metinler as o inner join kategoriler as b on o.kategoriid = b.kategoriid where kategori=@kategori", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@kategori",tür);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridMetinler.DataSource = tablo;
                
                baglanti.Close();
            }

            this.dataGridMetinler.Columns["id"].Visible = false;

        }
      
        private void KayıtlıMetinler_Load(object sender, EventArgs e)
        {
            MetinGetir();
           
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM kategoriler", baglanti);
            baglanti.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                
                cbtür.Items.Add(sqlReader["kategori"].ToString());
                cbkategori.Items.Add(sqlReader["kategori"].ToString());

                }

                sqlReader.Close();
                baglanti.Close();
            
            



        }

        

        private void dataGridMetinler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Close();
            lblid.Text = dataGridMetinler.CurrentRow.Cells[0].Value.ToString();
            BaslikTextBox.Text = dataGridMetinler.CurrentRow.Cells[1].Value.ToString();
            MetinTextBox.Text = dataGridMetinler.CurrentRow.Cells[2].Value.ToString();
            cbkategori.Text = dataGridMetinler.CurrentRow.Cells[3].Value.ToString();
            SqlCommand sqlCmd = new SqlCommand("SELECT kategoriid FROM kategoriler where kategori='" + MetinTextBox.Text + "'", baglanti);
            baglanti.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {


                lblkategoriid.Text = sqlReader[0].ToString();

            }

            sqlReader.Close();
            baglanti.Close();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into metinler(baslik,metin,kategoriid) values (@baslik, @metin,@kategoriid)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@baslik", BaslikTextBox.Text);
            komut.Parameters.AddWithValue("@metin", MetinTextBox.Text);
            komut.Parameters.AddWithValue("@kategoriid", kategori);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MetinGetir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string metinbaslik = BaslikTextBox.Text.Trim();
            DialogResult result = MessageBox.Show('"' + BaslikTextBox.Text + '"' + " kategorisini silmek istediğinize emin misiniz?", "DİKKAT!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                string sorgu = "delete from metinler where id=@id";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(lblid.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MetinGetir();


            }
           


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update metinler set baslik = @baslik, metin = @metin, kategoriid = @kategoriid where id = @id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(lblid.Text));
            komut.Parameters.AddWithValue("@baslik", BaslikTextBox.Text);
            komut.Parameters.AddWithValue("@metin", MetinTextBox.Text);
            komut.Parameters.AddWithValue("@kategoriid",kategori);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MetinGetir();
        }

        private void cbtür_SelectedIndexChanged(object sender, EventArgs e)
        {

            
               tür= cbtür.Text.ToString();
                MetinGetir();
            
            

            
        }
        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            string sorgu = "select kategoriid from kategoriler where kategori='" + cbkategori.Text.ToString()+"'";
            komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader sqlReader = komut.ExecuteReader();

            while (sqlReader.Read())
            {


                kategori = sqlReader[0].ToString();

            }

            sqlReader.Close();
            baglanti.Close();

        }

        private void kategoridüzenle(object sender, EventArgs e)
        {
            KategoriDüzenle ktgrdüzenle = new KategoriDüzenle();


            ktgrdüzenle.Show();
        }


        private void yenile_Click(object sender, EventArgs e)
        {   baglanti.Close();
            
            cbkategori.Items.Clear();
            cbtür.Items.Clear();
            cbtür.Items.Add("Hepsi");
            cbtür.Text = "Hepsi";
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM kategoriler", baglanti);
            baglanti.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {

                cbtür.Items.Add(sqlReader["kategori"].ToString());
                cbkategori.Items.Add(sqlReader["kategori"].ToString());

            }
            tür = "Hepsi";
            sqlReader.Close();
            baglanti.Close();
            MetinGetir();
        }















































        //------------OKUTMA İŞLEMLERİ--------------------//
        //------------OKUTMA İŞLEMLERİ--------------------//
        //------------OKUTMA İŞLEMLERİ--------------------//
        //------------OKUTMA İŞLEMLERİ--------------------//


        private void baslat_Click(object sender, EventArgs e)
        {

            bool SayiMi(string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
            ikileme = false;
            if (txtGenislik.Text == "" || MetinTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz.");
            }
            else if ((SayiMi(txtGenislik.Text) != true))
            {
                MessageBox.Show("Genişlik kısmı rakam olmak zorundadır.");
            }
            else if (Convert.ToInt32(txtGenislik.Text) <= 0 || Convert.ToInt32(txtGenislik.Text) > 27)
            {
                MessageBox.Show("Metin genişliği 1 ile 27 arasında bir değer olmalıdır.");
            }

            else
            {
                okutucu2 = new OkumaEkranı();

                kelimeler = MetinTextBox.Text;



                ayrılmıs = kelimeler.Trim().Split();
                ayrılmıs = ayrılmıs.Where(x => x != "").ToArray();

                toplamkelime = ayrılmıs.Length;


                metinsınır = Convert.ToInt32(txtGenislik.Text);


                int değer = Convert.ToInt32(HizComboBox.Text);

                değer = 10 - değer;

                okumatimer.Interval = 100 * değer;

                sayac = -1;

                yerelsayac = 0;

                okutucu2.Show();

                okumatimer.Start();


            }










        }

        private void kmtimerolayi(object sender, EventArgs e)
        {
            if (okutucu2.baslangic == true)
            {
                if (okutucu2.bastan == true)
                {

                    sayac = -1;
                    okutucu2.bastan = false;
                }


                yerelsayac = sayac;

                if (sayac >= toplamkelime - 1)
                {
                    okutucu2.lblKelime.ForeColor = System.Drawing.Color.Red;
                    okutucu2.lblKelime.Text = "BİTTİ";
                    okumatimer.Stop();
                    DialogResult result = MessageBox.Show("Metin Bitti! Baştan başlatmak ister misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        okutucu2.lblKelime.Text = "";
                        okumatimer.Start();
                        sayac = -1;
                        okutucu2.bastan = true;



                    }
                    else
                    {
                        okumatimer.Stop();
                        sayac = -1;
                    }

                }
                else if (okutucu2.kapandi == true)
                {
                    okumatimer.Stop();

                }
                else
                {
                    if (okutucu2.durdu == true && sayac != -1)
                    {

                        sayac = yerelsayac - wsayac;
                    }
                    else
                    {
                        sayac++;

                    }


                    temizmetin = ayrılmıs[sayac].Trim(ayirmachar).Trim();
                    temizmetin = temizmetin.Trim();
                    wsayac = 0;
                    if (okutucu2.durdu == false)
                    {
                        okutucu2.lblKelime.ForeColor = System.Drawing.Color.White;
                    }


                    while (true)
                    {

                        if (okutucu2.durdu == true)
                        {
                            break;
                        }

                        if (ikileme == true)
                        {
                            okutucu2.lblKelime.ForeColor = System.Drawing.Color.Yellow;

                        }
                        else
                        {
                            okutucu2.lblKelime.ForeColor = System.Drawing.Color.White;
                        }




                        if ((temizmetin.Replace(" ", "")).Length >= metinsınır)
                        {
                            if (sayac != toplamkelime - 1 && temizmetin.Trim(ayirmachar).Trim() == ayrılmıs[sayac + 1].Trim(ayirmachar).Trim())
                            {
                                if (ikileme == true)
                                {
                                    ikileme = false;
                                }
                                else
                                {
                                    ikileme = true;
                                }


                                okutucu2.lblKelime.Text = temizmetin.Trim();


                                break;


                            }
                            else
                            {
                                ikileme = false;
                                okutucu2.lblKelime.Text = temizmetin.Trim();

                                break;
                            }

                        }
                        else
                        {
                            if (sayac + 1 == ayrılmıs.Length)
                            {


                                okutucu2.lblKelime.Text = temizmetin.Trim();

                                break;
                            }
                            else
                            {
                                if (ayrılmıs[sayac + 1].Trim(ayirmachar).Length > metinsınır - temizmetin.Replace(" ", "").Length)
                                {

                                    okutucu2.lblKelime.Text = temizmetin.Trim();

                                    break;

                                }
                                else
                                {
                                    temizmetin = temizmetin + " " + ayrılmıs[sayac + 1].Trim(ayirmachar);

                                    sayac++;
                                    wsayac++;


                                }

                            }

                        }
                    }


                }

            }
            ///
        }

     
    }
}
