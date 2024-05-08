using System.ComponentModel.DataAnnotations;

namespace PustokMvc.Models
{
    public class Genre :AuditEntity
    {
        [MaxLength(20)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
