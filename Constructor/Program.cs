using System;

public class Bebek
{
    // Özellikler
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    // Default Constructor
    public Bebek()
    {
        DogumTarihi = DateTime.Now; // Şu anki tarihi ayarla
        Console.WriteLine("Ingaaaa");
    }

    // Alternatif Constructor
    public Bebek(string ad, string soyad)
    {
        Ad = ad; // Adı ayarla
        Soyad = soyad; // Soyadı ayarla
        DogumTarihi = DateTime.Now; // Şu anki tarihi ayarla
        Console.WriteLine("Ingaaaa");
    }
}

class Program
{
    static void Main()
    {
        // İlk bebek (parametre almadan)
        Bebek bebek1 = new Bebek();
        Console.WriteLine($"Bebek 1 - Ad: {bebek1.Ad}, Soyad: {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

        // İkinci bebek (ad ve soyad ile)
        Bebek bebek2 = new Bebek("Ali", "Yılmaz");
        Console.WriteLine($"Bebek 2 - Ad: {bebek2.Ad}, Soyad: {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");
    }
}
