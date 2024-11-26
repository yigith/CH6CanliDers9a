using System.ComponentModel.DataAnnotations;

namespace MVCCrudOrnek.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }

        public string Ad { get; set; } = "";

        public string Takim { get; set; } = "";

        public int DogumYili { get; set; }
    }
}
