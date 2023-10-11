using SwaggerTest.Common.Enums;

namespace SwaggerTest.Common.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public int Age { get; set; }

        public Role Role { get; set; }
    }
}
