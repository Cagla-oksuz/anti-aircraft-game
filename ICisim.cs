namespace Ucaksavar
{

    //The interface of the object class
    internal interface ICisim
    {
        int HareketMesafesi { get; set; }
        bool HareketEttir(Yon yon);
        bool Durdur(Dur esc);
      
    }
}
