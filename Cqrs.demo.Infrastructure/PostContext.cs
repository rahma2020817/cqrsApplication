using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure.EntityTypeBuilder;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.demo.Infrastructure;

public class PostContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    public PostContext(DbContextOptions<PostContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new PostEntityTypeBuilder());
        modelBuilder.ApplyConfiguration(new PostCommentEntityBuilder());
        modelBuilder.ApplyConfiguration(new PostInteractionEntityBuilder());
        modelBuilder.ApplyConfiguration(new UserProfileConfig());
    }
}