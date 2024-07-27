using Core_Proje_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KARAKUS\\KARAKUS;initial Catalog=CoreProjeDB2;integrated Security=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
