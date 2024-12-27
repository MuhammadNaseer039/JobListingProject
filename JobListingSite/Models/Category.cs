using System.ComponentModel.DataAnnotations;

namespace JobListingSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Category Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Category Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter Slug for Category e.g remote-job")]
        [Display(Name = "Slug")]
        public string Slug { get; set; }
    }
}
