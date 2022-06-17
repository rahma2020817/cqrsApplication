using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure.EntityTypeBuilder;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.demo.Infrastructure;

public class PostContext : DbContext
{
    public PostContext(DbContextOptions<PostContext> options) : base(options)
    {
        
    }
    
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostEntityTypeBuilder());
    }
}