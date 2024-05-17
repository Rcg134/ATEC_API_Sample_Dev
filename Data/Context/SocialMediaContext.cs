using ATEC_API_Sample.DomainModels.SocialMedia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ATEC_API_Sample.Data.Context
{
    public class SocialMediaContext : DbContext
    {
        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}
