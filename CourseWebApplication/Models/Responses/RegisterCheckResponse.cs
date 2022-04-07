using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.folder
{
    public class RegisterCheckResponse
    {
        [Required]
        public bool Exists { get; set; }
    }
}
