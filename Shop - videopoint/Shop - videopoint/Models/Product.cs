using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Shop___videopoint.Models
{
    public class Product : IEntity
    {
        [Required]
        [MaxLength(60), MinLength(5)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        // public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}