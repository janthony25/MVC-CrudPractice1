using Microsoft.EntityFrameworkCore;
using MVC_CrudPractice1.Models;

namespace MVC_CrudPractice1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
