using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class TokenRequest
    {
        [Required]
        public string AccessToken { get; set; }
    }
}
