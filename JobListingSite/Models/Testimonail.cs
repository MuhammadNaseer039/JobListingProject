using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobListingSite.Models
{
    public class Testimonail
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Occupation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "Please Enter Review")]
        public string Review { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IBrowserFile Picture { get; set; }
    }
}
