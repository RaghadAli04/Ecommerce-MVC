using Microsoft.EntityFrameworkCore;
using mvc_project.Models;

namespace mvc_project.Areas.User.Data
{
    public class ApplicationDbCotext : DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
        
    }
}