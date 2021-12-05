using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//In this class, the game starts when the necessary click is done from the console.
//aircraft projectiles and rockets accelerate through a timer movement gains operation
//Each hit counts for 5 points and when the score reaches 30,
//the aircraft ascent speed and movement speed increase
//the highest score is calculated
//When any of the planes reaches the ground, the game is over and the counters are reset and the lists are cleared.
namespace Ucaksavar
{
    internal class Oyun : IDisposable
    {
        
        private Label score;
        private Label scoreW;
        private Label enİyiPuanlar;
        private Ucaksavar _ucakSavar;
        private Timer _oyunTimer;
        private Timer _hareketTimer;
        
        private Random _random;
        private Random _randomYeni;
        private readonly Panel _oyunPaneli;
        private int _count=0;
        int[] Puanlar = new int[100];  
        private List<Mermi> _mermiListesi; 
        private List<Ucak> _ucakListesi;


        private List<Mermi> _mermiListesiYeni;
        private List<Ucak> _ucakListesiYeni;

        public bool OynaniyorMu => _oyunTimer != null && _oyunTimer.Enabled;
        public Oyun(Panel oyunPaneli)
        {
            _oyunPaneli = oyunPaneli;

            score = new Label();
            score.AutoSize = true;
            score.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            score.ForeColor = Color.Black;
            score.Location = new Point(950, 2);
            score.Name = "score1";
            score.Size = new Size(100, 70);
            score.TabIndex = 6;
            score.Text = "0";
            _oyunPaneli.Controls.Add(score);

            scoreW = new Label();
            scoreW.AutoSize = true;
            scoreW.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            scoreW.ForeColor = Color.Black;
            scoreW.Location = new Point(890, 2);
            scoreW.Name = "score";
            scoreW.Size = new Size(100, 70);
            scoreW.TabIndex = 6;
            scoreW.Text = "Score :";
            _oyunPaneli.Controls.Add(scoreW);          
        }

        public void Dispose()
        {
            _oyunTimer?.Dispose();
        }
        //yeni oyun baslar
        public void Baslat()
        {
           
            if (_oyunTimer != null) 
            _oyunPaneli.Controls.Clear();

            _mermiListesi = new List<Mermi>();
            _ucakListesi = new List<Ucak>();
            _random = new Random();

            UcaksavarYerlestir();
            ZamanlayicilariOlusturBaslat();
        }
      
        //yeni ucaksavar
        private void UcaksavarYerlestir()
        {
            _ucakSavar = new Ucaksavar();
            _ucakSavar.Left = Convert.ToInt32(Math.Round((_oyunPaneli.Width - _ucakSavar.Width)/2.0));
            _ucakSavar.Top = _oyunPaneli.Height - _ucakSavar.Height;
            _ucakSavar.HareketAlaniGenislik = _oyunPaneli.Width;
            _ucakSavar.HareketAlaniYukseklik = _oyunPaneli.Height;
            _oyunPaneli.Controls.Add(_ucakSavar);
        }
        //bitirir
        int k = 0;
        public void Bitir()
        {
            k++;
            ZamanlayicilariDurdurSil();
            _mermiListesi = null;
            _ucakListesi = null;
            int Puan = Counter();
            Puanlar[k] = Puan;
            
            Random rnd = new Random();
            int mak;

            for (int i = 0; i < 100; i++)
            {
                Puanlar[i] = rnd.Next(1, 100);
               
            }           
            mak = Puanlar[0];
            for (int i = 1; i <Puanlar.Length; i++)
            {  
                if (mak < Puanlar[i])
                    mak = Puanlar[i];               
            }/*
            enİyiPuanlar = new Label();
            enİyiPuanlar.AutoSize = true;
            enİyiPuanlar.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));           
            enİyiPuanlar.Name = "puan";
            enİyiPuanlar.Size = new Size(300, 70);
            enİyiPuanlar.Visible = true;
            enİyiPuanlar.Text = "" + mak;
            _oyunPaneli.Controls.Add(enİyiPuanlar);   
            */
        }
        //durur ve siler
        private void ZamanlayicilariDurdurSil()
        {
            _oyunTimer.Stop();
            _oyunTimer.Dispose();      
            _hareketTimer.Stop();
            _hareketTimer.Dispose();
        }
        
        //zamanlayıcıları olustur baslar
        private void ZamanlayicilariOlusturBaslat()
        {
            _oyunTimer = new Timer { Interval = 2000 };
            _oyunTimer.Tick += OyunTimerTick;
            _oyunTimer.Start();

            _hareketTimer = new Timer { Interval = 100 };
            _hareketTimer.Tick += HareketTimerTick;
            _hareketTimer.Start();

            YeniUcakOlustur();
        }
     
        //Esc basıldığında başlamasını sağlayan fonksiyon
        public bool DuraniBaslat()
        {  
            _oyunTimer = new Timer { Interval = 2000 };
            _oyunTimer.Tick += OyunTimerTick;
            _oyunTimer.Start();
            _hareketTimer.Start();
            return true;
        }
        //Esc basıldığında durmasını sağlayan fonksiyon
        public bool Durdur()
        {
            if (_oyunTimer != null)
            {
                _oyunTimer.Stop();
                _hareketTimer.Stop();
            }
            return true;
        }
        
        private void OyunTimerTick(object sender, EventArgs e)
        {
            YeniUcakOlustur();
        }

        //vurulan ucagı durdur
        public bool VurulanUcaklariCikar()
        {
            for (var i = _ucakListesi.Count - 1; i >= 0; i--)
            {
                var ucak = _ucakListesi[i];
                for (var j = _mermiListesi.Count - 1; j >= 0; j--)
                {
                    var mermi = _mermiListesi[j];

                    if (ucak.Bottom < mermi.Top) continue;
                    if (ucak.Left > mermi.Right) continue;
                    if (ucak.Right < mermi.Left) continue;

                    _ucakListesi.RemoveAt(i);
                    _mermiListesi.RemoveAt(j);
                    _oyunPaneli.Controls.Remove(ucak);
                    _oyunPaneli.Controls.Remove(mermi);
                    Counter();
                }
            }
            return true;
        }
        //benim oynadığım 
        public int Counter()
        {           
            _count += 5;
            score.Text = _count.ToString();
            _oyunPaneli.Controls.Add(score);
            if (_count == 30)
            {
                // Zorluk seviyesini artırır
                _oyunTimer.Stop();
                _oyunTimer.Interval = 700;
                _hareketTimer.Stop();
                _hareketTimer.Interval = 35;
                _oyunTimer.Start();
                _hareketTimer.Start();
             
            }
            return _count;
        }
        //yeni ucak oluştur
        private void YeniUcakOlustur()
        {
            var ucak = new Ucak();
            ucak.Left = ucak.Width * _random.Next(0, Convert.ToInt32(Math.Round(Convert.ToDouble(_oyunPaneli.Width) / ucak.Width)));
            ucak.Top = 0;
            ucak.HareketAlaniGenislik = _oyunPaneli.Width;
            ucak.HareketAlaniYukseklik = _oyunPaneli.Height;

            //bu eskisi. Burada işlem yapıyor ben yenisi yaptım iyice kafayı yıyor
            //Burada yenisini mi çağırmak istiyorsun aslında evetbak dur asından söyle
            _ucakListesi.Add(ucak);
            _oyunPaneli.Controls.Add(ucak);
        }

        //hareket
        private void HareketTimerTick(object sender, EventArgs e)
        {
            // Tüm mermiler kontrol ediliyor
            //Bu eski liste
            //Oyunu hızlandırmak için sadece time'ın intervalini değiştirsen olmuyor mu
            for (var i = _mermiListesi.Count - 1; i >= 0; i--)
            {
                var mermi = _mermiListesi[i];

                var oyunAlaniDisinaCiktiMi = mermi.HareketEttir(Yon.Yukari);
                if (!oyunAlaniDisinaCiktiMi) continue;

                _mermiListesi.RemoveAt(i);
                _oyunPaneli.Controls.Remove(mermi);
            }

            // Tüm uçaklar kontrol ediliyor
            for (var i = _ucakListesi.Count - 1; i >= 0; i--)
            {
                var ucak = _ucakListesi[i];
                var oyunAlaniDisinaCiktiMi = ucak.HareketEttir(Yon.Asagi);
                if (!oyunAlaniDisinaCiktiMi) continue;

                Bitir();
                return;
            }
            VurulanUcaklariCikar();
        }
        //ates
        public void AtesEt()
        {
            YeniMermiOlustur();       
        }
        //yeni mermi üret
        private void YeniMermiOlustur()
        {
            var mermi = new Mermi();
            mermi.Left = _ucakSavar.Left + Convert.ToInt32(Math.Round((_ucakSavar.Width - mermi.Width) / 2.0));
            mermi.Top = _oyunPaneli.Height - _ucakSavar.Height - mermi.Height;
            mermi.HareketAlaniGenislik = _oyunPaneli.Width;
            mermi.HareketAlaniYukseklik = _oyunPaneli.Height;

            _mermiListesi.Add(mermi);
            _oyunPaneli.Controls.Add(mermi);
        }
        //hareket ettir
        public void UcaksavariHareketEttir(Yon yon)
        {
            _ucakSavar.HareketEttir(yon);
        }
        //dur
        public void Durdur(Dur dur)
        {
            _ucakSavar.DuraniBaslat();
            
        }
    }
}
