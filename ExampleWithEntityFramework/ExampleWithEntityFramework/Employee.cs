using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleWithEntityFramework
{
    public class Employee : IdentifyEntity
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "datetime2")]
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public bool IsMan { get; set; }
        public virtual Position Position { get; set; }
    }
}