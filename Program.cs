using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.ID = 1;
        musteri1.AdiSoyadi = "Hatice Akpolat";
        musteri1.Uyruk = "TC";
        musteri1.Meslegi = "Elektronik Haberleşme Mühendisi";
        musteri1.Yasi = 29;

        Musteri musteri2 = new Musteri();
        musteri2.ID = 2;
        musteri2.AdiSoyadi = "Melek Avcı";
        musteri2.Uyruk = "TC";
        musteri2.Meslegi = "Emekli Astsubay";
        musteri2.Yasi = 43;

        Musteri musteri3 = new Musteri();
        musteri3.ID = 3;
        musteri3.AdiSoyadi = "Jennifer Lawrence";
        musteri3.Uyruk = "USA";
        musteri3.Meslegi = "Oyuncu";
        musteri3.Yasi = 33;


        Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
        MusteriManager musteriManager = new MusteriManager();

        foreach (Musteri musteri in musteriler)
        {
            musteriManager.MusteriEkle(musteri);
            Console.WriteLine("-----Müşteri bilgileri----");
            musteriManager.MusteriListele(musteri);
            musteriManager.MusteriSil(musteri);
        }

    }
}