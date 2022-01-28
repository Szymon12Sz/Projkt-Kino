using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Udemy_Kino.Data.Base;

namespace Udemy_Kino.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema Logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        //Relations
        public List<Movie> Movies { get; set; }

    }
}
