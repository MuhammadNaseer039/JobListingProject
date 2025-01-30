using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobListingSite.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Job Title")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Job Category")]
        public string Nature { get; set; }
        [Required(ErrorMessage = "Please Enter Job Salary")]
        public string Salary { get; set; }
        [Required(ErrorMessage = "Please Enter Job Last Date to Apply")]
        public string LastDateToApply { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IBrowserFile Picture { get; set; }
    }
}
