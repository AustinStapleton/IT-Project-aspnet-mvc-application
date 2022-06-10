using IT_Project.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IT_Project.Models
{
    public class Studio:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Studio Logo")]
        [Required(ErrorMessage = "Studio logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Studio Name")]
        [Required(ErrorMessage = "Studio name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Studio description is required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
