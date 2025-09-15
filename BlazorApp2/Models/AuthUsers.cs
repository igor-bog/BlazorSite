using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class AuthUser
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = ""; // 
    }
}
