using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Moderate
    {
        [Required]
        public string SearchText { get; set; }

        
    }
}
