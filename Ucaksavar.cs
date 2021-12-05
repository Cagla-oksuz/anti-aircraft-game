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
//cisim sınıfından kalıtım alır çünkü uçaksavar bir cisimdir. resmin konumu ve boyutu tanımlanır.
namespace Ucaksavar
{
    internal class Ucaksavar : Cisim
    {
        public Ucaksavar()
        {
            Image = System.Drawing.Image.FromFile(@"ucaksavar.png");
            HareketMesafesi = Image.Width; // Kendi genişliği kadar
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        internal void DuraniBaslat()
        {
            throw new NotImplementedException();
        }
    }
}
