using System.ComponentModel.DataAnnotations;

namespace ExampleWithEntityFramework
{
    public class Position : IdentifyEntity
    {
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
    }
}