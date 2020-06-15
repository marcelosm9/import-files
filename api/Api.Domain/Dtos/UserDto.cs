using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid e-mail.")]
        public string Email { get; set; }

        public string Birthday { get; set; }

        public string Gender { get; set; }
    }
}
