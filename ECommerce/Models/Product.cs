using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
