using System.ComponentModel.DataAnnotations;

namespace SwaggerTest.Common.DTOs
{
    public class UserUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [Range(0, 150,
            ErrorMessage = "Invalid data!")]
        public int Age { get; set; }
    }
}
