using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shop___videopoint.Models
{
    [Table("Produkty")]
    public class Product : IEntity
    {

        [Required]
        [MinLength(10),MaxLength(60)]
        [Column("Nazwa")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Review> Review { get; set; }
    }
}