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
//cisim sınıfından kalıtım alır çünkü uçak bir cisimdir. resmin konumu ve boyutu tanımlanır.
namespace Ucaksavar
{
    internal class Ucak : Cisim
    {
        public Ucak()
        {
            Image = System.Drawing.Image.FromFile(@"ucak.png");
            HareketMesafesi = Convert.ToInt32(Math.Round(Image.Height * .1)); // Kendi yüksekliğinin onda biri
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
