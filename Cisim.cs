using System;
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
//Cisim sınıfında cisim haretleri için set get fonksiyonları tanımlanır ve hareket işlemi için metod yazılır
//Space işlemi görmek için Dur tanımlanır set, get ve space işlemi için gerekli fonksiyonlar tanımlanır
namespace Ucaksavar
{
    internal abstract class Cisim : PictureBox, ICisim
    {
        public int HareketMesafesi { get; set; }
        public int HareketAlaniGenislik { get; set; }
        public int HareketAlaniYukseklik { get; set; }
        public Dur Esc { get; private set; }

  
        public bool DuraniBaslat(Dur esc)
        {
            if (Dur.Esc == esc)
            {
                return false;
            }
            return true;
        }
       
      
            public bool HareketEttir(Yon yon)
        { 
            switch (yon)
            {
                case Yon.Sag:
                    if (Right + HareketMesafesi > HareketAlaniGenislik)
                    {
                        Left = HareketAlaniGenislik - Width;
                        return true;
                    }
                    Left += HareketMesafesi;
                    break;
                 case Yon.Sol:
                    if (Left - HareketMesafesi < 0)
                    {
                        Left = 0;
                        return true;
                    }
                    Left -= HareketMesafesi;
                    break;
               case Yon.Asagi:
                    if (Bottom + HareketMesafesi > HareketAlaniYukseklik)
                    {
                        Top = HareketAlaniYukseklik - Height;
                        return true;
                    }
                    Top += HareketMesafesi;
                    break;
                case Yon.Yukari:
                    if (Top - HareketMesafesi < 0)
                    {
                        Top = 0;
                        return true;
                    }
                    Top -= HareketMesafesi;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return false;
        }

        public bool Durdur(Dur esc)
        {
            if (Dur.Esc ==esc)
            {
                return true;
            }
            return false;
        }

    }
}
