using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bookify.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public String Name { get; set; }

        [Required]
        [Range(1,100,ErrorMessage ="Range out of limit is between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
