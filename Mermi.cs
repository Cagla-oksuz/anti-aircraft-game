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
//cisim sınıfından kalıtım alır çünkü mermi bir cisimdir. resmin konumu ve boyutu tanımlanır.
namespace Ucaksavar
{
    internal class Mermi : Cisim
    {
        public Mermi()
        {
            Image = System.Drawing.Image.FromFile(@"mermi.png");
            HareketMesafesi = Convert.ToInt32(Math.Round(Image.Height * 1.5)); // Kendi yüksekliğinin 1,5 katı
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
