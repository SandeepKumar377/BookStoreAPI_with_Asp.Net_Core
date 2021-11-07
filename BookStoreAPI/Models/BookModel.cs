using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the Title!")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
