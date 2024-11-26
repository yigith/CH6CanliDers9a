namespace MVCCrudOrnek.Models
{
    public static class Veri
    {
        public static List<Ogrenci> Ogrenciler { get; set; } = new()
        {
            new Ogrenci { Id = 1, Ad = "Begüm", DogumYili = 1999, Takim = "Galatasaray" },
            new Ogrenci { Id = 2, Ad = "Berkan", DogumYili = 2000, Takim = "Galatasaray" },
            new Ogrenci { Id = 3, Ad = "Mehmet Ali", DogumYili = 1996, Takim = "Galatasaray" },
            new Ogrenci { Id = 4, Ad = "Murat", DogumYili = 2004, Takim = "Fenerbahçe" },
            new Ogrenci { Id = 5, Ad = "Serhat", DogumYili = 2003, Takim = "Fenerbahçe" },
            new Ogrenci { Id = 6, Ad = "Mahir", DogumYili = 1998, Takim = "Beşiktaş" },
            new Ogrenci { Id = 7, Ad = "Yaşar", DogumYili = 2001, Takim = "Göztepe" },
            new Ogrenci { Id = 8, Ad = "Melis", DogumYili = 2001, Takim = "Antalyaspor" }
        };
    }
}
