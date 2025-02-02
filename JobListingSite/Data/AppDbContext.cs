using JobListingSite.Models;
using Microsoft.EntityFrameworkCore;

namespace JobListingSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> tbl_categories {  get; set; }
        public DbSet<Job> tbl_jobs { get; set; }
        public DbSet<Testimonail> tbl_testimonials { get; set; }
        public DbSet<users> tbl_users { get; set; }
    }
}
