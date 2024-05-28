using System.ComponentModel.DataAnnotations;

namespace KhumaloCraftWebApp.Models
{
    public class ContactMessage
    {
        [Key]
        public int MessageID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
