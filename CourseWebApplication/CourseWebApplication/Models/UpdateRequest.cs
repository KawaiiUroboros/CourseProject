using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UpdateRequest
    {
        [Required]
        public string Password { get; set; }
    }
}
