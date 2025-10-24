using Microsoft.EntityFrameworkCore;

namespace ContactMonthlyClaim02.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //  Adding database tables here
        public DbSet<Claim> Claims { get; set; }
    }
}
