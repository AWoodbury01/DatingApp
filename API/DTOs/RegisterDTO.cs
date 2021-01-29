using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    // Registers the username and password into the db
    public class RegisterDTO
    {
        [Required]
        public string Username { get; set;}

        [Required]
        public string Password { get; set;}
    }
}