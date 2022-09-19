using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hızlı_Okuma_Uygulaması
{
    public partial class Form1 : Form
    {
       

        string kelimeler;
        string[] ayrılmıs;
        int toplamkelime;
        int sayac = -1;
        int metinsınır;
        int wsayac;
        OkumaEkranı okutucu;
        bool ikileme = false;
       
        int yerelsayac;

        char[] ayirmachar = { '*', ',', '.', '-', '+', ' ', '!', '?', '^', '#', '$', ':', ';', '_', '\'', '"', '\\', '/','(',')','~','<','>','|','{','}','[',']','&','='};

        string temizmetin;
          

    public Form1()
        {
            InitializeComponent();
            HizComboBox.Text = "1";
            
        }
        
        private void OkumayaBasla(object sender, EventArgs e)
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
            if (txtGenislik.Text == "" || AnaTextBox.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurunuz.");
            }
            else if((SayiMi(txtGenislik.Text) != true))
            {
                MessageBox.Show("Genişlik kısmı rakam olmak zorundadır.");
            }
            else if(Convert.ToInt32(txtGenislik.Text)<=0 || Convert.ToInt32(txtGenislik.Text) >27)
            {
                MessageBox.Show("Metin genişliği 1 ile 27 arasında bir değer olmalıdır.");
            }
           
            else 
            { 
            okutucu = new OkumaEkranı();
            
            kelimeler = AnaTextBox.Text;

            

            ayrılmıs = kelimeler.Trim().Split();
            ayrılmıs = ayrılmıs.Where(x => x != "").ToArray();

             toplamkelime = ayrılmıs.Length;

            
            metinsınır = Convert.ToInt32(txtGenislik.Text);


            int değer = Convert.ToInt32(HizComboBox.Text);
            
            değer = 10 - değer;
            
            okumatimer.Interval = 100 * değer;

             sayac = -1;

             yerelsayac = 0;

            okutucu.Show();
            
            
            
            okumatimer.Start();


            }


        }

       

        private void OkumaTimerOlayı(object sender, EventArgs e)
        {

            if(okutucu.baslangic == true)
            {
                if (okutucu.bastan == true)
                {

                    sayac = -1;
                    okutucu.bastan = false;
                }


                yerelsayac = sayac;

                if (sayac >= toplamkelime - 1)
                {
                    okutucu.lblKelime.ForeColor = System.Drawing.Color.Red;
                    okutucu.lblKelime.Text = "BİTTİ";
                    okumatimer.Stop();
                    DialogResult result = MessageBox.Show("Metin Bitti! Baştan başlatmak ister misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        okutucu.lblKelime.Text = "";
                        okumatimer.Start();
                        okutucu.bastan = true;



                    }
                    else
                    {
                        okumatimer.Stop();
                        sayac = -1;
                    }

                }
                else if (okutucu.kapandi == true)
                {
                    okumatimer.Stop();

                }
                else
                {
                    if (okutucu.durdu == true && sayac != -1)
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
                    if (okutucu.durdu == false)
                    {
                        okutucu.lblKelime.ForeColor = System.Drawing.Color.White;
                    }

                    
                    while (true)
                    {

                        if (okutucu.durdu == true)
                        {
                            break;
                        }

                        if (ikileme == true)
                        {
                            okutucu.lblKelime.ForeColor = System.Drawing.Color.Yellow;

                        }
                        else
                        {
                            okutucu.lblKelime.ForeColor = System.Drawing.Color.White;
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


                                okutucu.lblKelime.Text = temizmetin.Trim();


                                break;


                            }
                            else
                            {
                                ikileme = false;
                                okutucu.lblKelime.Text = temizmetin.Trim();

                                break;
                            }

                        }
                        else
                        {   
                            if (sayac + 1 == ayrılmıs.Length)
                            {


                                okutucu.lblKelime.Text = temizmetin.Trim();

                                break;
                            }
                            else
                            {                         
                                if (ayrılmıs[sayac + 1].Trim(ayirmachar).Length > metinsınır - temizmetin.Replace(" ", "").Length)
                                {

                                    okutucu.lblKelime.Text = temizmetin.Trim();

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




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kayıtlımetinler(object sender, EventArgs e)
        {
            KayıtlıMetinler kytmetinler = new KayıtlıMetinler();


            kytmetinler.Show();
        }















        private void YardımıGoster(object sender, EventArgs e)
        {
            YardımEkranı yardımgoster = new YardımEkranı();

            yardımgoster.Show();
        }
    }
}
