using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarsAPI.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }

        
    }
}
