using Microsoft.EntityFrameworkCore;
using mysqldemo.Models;

namespace mysqldemo.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        { }

        public DbSet<table1> table1 { get; set; }

    }
}
