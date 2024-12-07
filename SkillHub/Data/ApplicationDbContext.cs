using Microsoft.AspNetCore.Identity; // This is necessary for IdentityDbContext
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkillHub.Models; // Your custom models, including ApplicationUser

namespace SkillHub.Data
{
    public class ApplicationUser : IdentityUser
    {
        // You can add any extra properties here as needed
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Ensure inheritance from IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define your DbSets, e.g. UserProfiles
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
