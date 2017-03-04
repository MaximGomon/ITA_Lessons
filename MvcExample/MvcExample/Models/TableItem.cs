using System.ComponentModel.DataAnnotations;

namespace MvcExample.Models
{
    public class TableItem
    {
        [Required]
        public int Id { get; set; }
        [MinLength(2), MaxLength(20)]
        public string Name { get; set; } 
    }
}