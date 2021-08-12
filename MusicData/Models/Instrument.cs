using System.ComponentModel.DataAnnotations;

namespace MusicData.Models
{
    public abstract class Instrument
    {
        public int Id { get; set; }

        [Required]
        public string BrandName { get; set; }

        [Required]
        public string BrandModel { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
