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
    public partial class OkumaEkranı : Form
    {
        public bool durdu = true;
        public bool kapandi = false;
        public bool bastan = false;
        public bool baslangic = false;

        public OkumaEkranı()
        {
            InitializeComponent();
        }

        private void DurdurmaOlayı(object sender, EventArgs e)
        {
           if(baslangic == false)
            {
                baslangic = true;
            }
            
            durdu = !durdu;

            if (durdu == true)
            {
                btnDurdur.Text = "Baslat";
            }
            else
            {
                btnDurdur.Text = "Durdur";
            }
        }

        private void OkumaEkranıYuklenme(object sender, EventArgs e)
        {
            
            int yükseklik = Screen.PrimaryScreen.Bounds.Height;
            int genişlik = Screen.PrimaryScreen.Bounds.Width;


            lblKelime.Height = yükseklik;
            lblKelime.Width = genişlik;

          


            kapandi = false;
            durdu = true;


        }

        private void OkumaEkranıKapama(object sender, FormClosedEventArgs e)
        {
            kapandi = true;
        }

       

        

       
    }
}
