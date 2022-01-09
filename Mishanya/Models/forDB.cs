using Microsoft.EntityFrameworkCore;

namespace Mishanya.Models
{
    public class forDB : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public forDB(DbContextOptions<forDB> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
