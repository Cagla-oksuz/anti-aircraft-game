using System;
using System.Drawing;
using System.Windows.Forms;
/*****************************************************
* *         Fakülte Adı : Haşim Gürdamar Bilgisayar ve Bilişim Bilimleri Fakültesi
* *         Bölüm : Bilişim Mühendisliği
* *         Öğrenci Adı : Buğra Ömer
* *         Öğrenci Soyadı : POLAT
* *         Öğrenci numarası : B171200052
* *         Sınıf : 1-A
* *         Öğretim Üyesi : Dr. Muhammed KOTAN
* *                     
* *****************************************************/
//Tıklama işlemlemleri gerçekleştiğinde hangi fonksiyonun işlemem koyulacağını belirlediğimiz sayfa
//Oyun classından ürettiğimiz _oyun değişkeni yardımıyla fonksiyon çağırma işlemini gerçekleştiriyoruz 
namespace Ucaksavar
{
    public partial class AnaForm : Form
    {
        private Oyun _oyun;

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    EnterTusunaBasildi();
                    break;
                case Keys.Space:
                    BoslukTusunaBasildi();
                    break;
                case Keys.Escape:
                    DurdurTusunaBasildi(Dur.Esc);
                    break;
                case Keys.Up:
                case Keys.NumPad8:
                    YonTusunaBasildi(Yon.Yukari);
                    break;
                case Keys.Right:
                case Keys.NumPad6:
                    YonTusunaBasildi(Yon.Sag);
                    break;
                case Keys.Down:
                case Keys.NumPad2:
                    YonTusunaBasildi(Yon.Asagi);
                    break;
                case Keys.Left:
                case Keys.NumPad4:
                    YonTusunaBasildi(Yon.Sol);
                    break;
            }
        }

        private void BoslukTusunaBasildi()
        {
            if (!OyunOynaniyorMu()) return;

            _oyun.AtesEt();
                            
        }
        private void DurdurTusunaBasildi(Dur tus)
        {
            if (OyunOynaniyorMu()) { _oyun.Durdur(); }
            else _oyun.DuraniBaslat();
        }
/*private void ScoreArttır()
        {
            if (_oyun.VurulanUcaklariCikar())
            {
                int sco = _oyun.Counter();
                score.Text = sco.ToString();
            }

        }*/

        private void YonTusunaBasildi(Yon yon)
        {
            if (!OyunOynaniyorMu()) return;
            if (yon == Yon.Asagi || yon == Yon.Yukari) return;

            _oyun.UcaksavariHareketEttir(yon);
        }

        private void EnterTusunaBasildi()
        {
            if (OyunOynaniyorMu()) return;

            _oyun = new Oyun(oyunPaneli);
            _oyun.Baslat();
        }

        private bool OyunOynaniyorMu()
        {

            return _oyun != null && _oyun.OynaniyorMu;

        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _oyun?.Dispose();
        }

        private void Devam_Click(object sender, System.EventArgs e)
        {

        }

       

        private void AnaForm_Load(object sender, System.EventArgs e)
        {

        }

        private void oyunPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        // score 
        /*
        private void update_Tick(object sender, EventArgs e)
        {
            int sco1 = _oyun.Counter();
            score.Text = "" + sco1;
            if (_oyun.VurulanUcaklariCikar())
            {
                int sco = _oyun.Counter();
                score.Text = ""+sco;
            }
            // if (!OyunOynaniyorMu()) Stop();
        } */
    }
}
