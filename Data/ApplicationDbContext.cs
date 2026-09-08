using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using mvc_project.Models;
namespace mvc_project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Catagory> Catagories {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Database=MVC15;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0");
        }
    }
}
