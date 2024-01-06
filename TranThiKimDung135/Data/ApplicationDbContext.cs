using TranThiKimDung135.Models;
using Microsoft.EntityFrameworkCore;
using TranThiKimDung135.Models;


namespace TranThiKimDung135.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    
    {}

    public DbSet<Person> Person { get; set; }
    }
}