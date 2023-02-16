using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class CreateImage
    {
        [Required]
        public string SearchText { get; set; }

        [Required]
        public int NoOfResults { get; set; } = 2;

        
    }
}
