using System.ComponentModel.DataAnnotations;

namespace DbEntity
{
    public class NameEntity : IdEntity
    {
        [MaxLength(250)]
        [MinLength(3)]
        [Required]
        public string Name { get; set; }
    }
}