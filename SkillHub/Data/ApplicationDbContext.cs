using Microsoft.EntityFrameworkCore;
using SkillHub.Models;


namespace SkillHub.Data
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}
