using emailverification.Model;
using Microsoft.EntityFrameworkCore;

namespace emailverification.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=EmailVerify;Integrated Security=True; Trusted_Connection = True ;TrustServerCertificate=True");
        }


        public DbSet<User> Users  =>  Set<User>();
    }
}
