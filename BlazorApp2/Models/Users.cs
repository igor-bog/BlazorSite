// Models/User.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
