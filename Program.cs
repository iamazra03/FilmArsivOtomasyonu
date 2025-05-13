using System;

namespace FilmArsiviOtomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Film Arşiv Otomasyonu ===");
                Console.WriteLine("1. Film Ekle");
                Console.WriteLine("2. Film Sil");
                Console.WriteLine("3. Film Güncelle");
                Console.WriteLine("4. Film Listele");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminiz: ");
                secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        // Film Ekleme
                        Film yeniFilm = new Film();
                        Console.WriteLine("Film Adı: ");
                        yeniFilm.FilmAdi = Console.ReadLine();
                        Console.WriteLine("Yönetmen: ");
                        yeniFilm.Yonetmen = Console.ReadLine();
                        Console.WriteLine("Tür: ");
                        yeniFilm.Tur = Console.ReadLine();
                        Console.WriteLine("Süre (dakika): ");
                        yeniFilm.Sure = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yıl: ");
                        yeniFilm.Yil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İzlendi (1=Evet, 0=Hayır): ");

                        // 1 ve 0 değerlerini boolean olarak çevirmek
                        int izlendiInput = Convert.ToInt32(Console.ReadLine());
                        yeniFilm.Izlendi = (izlendiInput == 1); // 1 ise true, 0 ise false

                        // Puan (0-10 arasında) girişini doğrulama
                        double puan;
                        do
                        {
                            Console.WriteLine("Puan (0 ile 10 arasında bir değer giriniz): ");
                            puan = Convert.ToDouble(Console.ReadLine());
                            if (puan < 0 || puan > 10)
                            {
                                Console.WriteLine("Geçersiz puan! Lütfen 0 ile 10 arasında bir değer girin.");
                            }
                        } while (puan < 0 || puan > 10);

                        yeniFilm.Puan = puan;

                        int sonuc = yeniFilm.Ekle();
                        if (sonuc > 0)
                        {
                            Console.WriteLine("Film başarıyla eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Film eklenemedi.");
                        }
                        break;

                    case 5:
                        // Çıkış
                        Console.WriteLine("Çıkılıyor...");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçenek.");
                        break;
                }

                Console.WriteLine("Devam etmek için bir tuşa basınız...");
                Console.ReadLine();
            } while (secim != 5);
        }
    }
}
