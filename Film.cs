using System;
using MySql.Data.MySqlClient;

namespace FilmArsiviOtomasyonu
{
    public class Film
    {
        public string FilmAdi { get; set; }
        public string Yonetmen { get; set; }
        public string Tur { get; set; }
        public int Sure { get; set; }
        public int Yil { get; set; }
        public bool Izlendi { get; set; }
        public double Puan { get; set; }

        public int Ekle()
        {
            string sorgu = "INSERT INTO filmler (filmadi, yönetmen, tur, sure, yil, izlendi, puan) " +
                           "VALUES (@FilmAdi, @Yonetmen, @Tur, @Sure, @Yil, @Izlendi, @Puan)";

            try
            {
                Veritabani.Baglan();
                MySqlCommand komut = new MySqlCommand(sorgu, Veritabani.GetConnection());
                komut.Parameters.AddWithValue("@FilmAdi", FilmAdi);
                komut.Parameters.AddWithValue("@Yonetmen", Yonetmen);
                komut.Parameters.AddWithValue("@Tur", Tur);
                komut.Parameters.AddWithValue("@Sure", Sure);
                komut.Parameters.AddWithValue("@Yil", Yil);
                komut.Parameters.AddWithValue("@Izlendi", Izlendi ? 1 : 0);
                komut.Parameters.AddWithValue("@Puan", Puan);
                int sonuc = komut.ExecuteNonQuery();
                Veritabani.Kapat();
                return sonuc;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Film eklenirken bir hata oluştu: " + ex.Message);
                return 0;
            }
        }
    }
}
