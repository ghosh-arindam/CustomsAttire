using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomsAttire.API.Auth
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        #nullable disable // at the top of the file
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        #nullable restore // after the block of code you wanted to temporarily disable
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Core Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Core Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // You don't actually ever need to call this
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=CustomsAttire;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
            }
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
