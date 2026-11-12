using System.ComponentModel.DataAnnotations;

namespace AnnonsApi.Models
{
    public class UpdateAd
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;


        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;


        [Range(0, 10000000)]
        public decimal Price { get; set; }
    }
}
