using System.ComponentModel.DataAnnotations;

namespace AnnonsApi.Entities
{
    public class Ad
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Desciption { get; set; } = string.Empty;

        [Range(0, 10000000)]
        public decimal Price { get; set; }
    }
}
