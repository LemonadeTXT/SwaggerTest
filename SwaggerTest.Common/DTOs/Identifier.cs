using System.ComponentModel.DataAnnotations;

namespace SwaggerTest.Common.DTOs
{
    public class Identifier
    {
        [Required]
        public int Id { get; set; }
    }
}
