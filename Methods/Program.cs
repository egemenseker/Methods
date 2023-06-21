namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            

            Urun[] urunler = new Urun[] { urun1, urun2};

            for (int i = 0; i < urunler.Length; i++) {

                Console.WriteLine(urunler[i].Adi);
                Console.WriteLine(urunler[i].Aciklama);
                Console.WriteLine(urunler[i].Fiyati);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("------------------------Metodlar-----------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);

        }
    }
}