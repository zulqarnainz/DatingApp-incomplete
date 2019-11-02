using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Please enter Username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Password.")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "you must specify password between 4 to 8 characters.")]
        public string Password { get; set; }
    }
}