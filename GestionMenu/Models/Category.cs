using System;
using System.ComponentModel.DataAnnotations;

namespace GestionMenu.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
