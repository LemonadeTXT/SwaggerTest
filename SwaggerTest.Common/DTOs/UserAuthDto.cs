using System.ComponentModel.DataAnnotations;

namespace SwaggerTest.Common.DTOs
{
    public class UserAuthDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
