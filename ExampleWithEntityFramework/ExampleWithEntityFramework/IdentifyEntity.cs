using System.ComponentModel.DataAnnotations;

namespace ExampleWithEntityFramework
{
    public class IdentifyEntity
    {
        [Key]
        public int Id { get; set; } 
    }
}