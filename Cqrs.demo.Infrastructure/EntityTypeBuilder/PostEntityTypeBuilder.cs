using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class PostEntityTypeBuilder : IEntityTypeConfiguration<Post>, IEntityTableName
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable(TableName);
        builder.ToTable(TableName).HasKey(p => p.PostId);
        builder.Property(x => x.CreatedDate)
            .HasDefaultValueSql("CURRENT_TIMESTAMP(20)")
            .ValueGeneratedOnAdd();
        
        builder.Property(x => x.LastModified)
            .HasDefaultValueSql("CURRENT_TIMESTAMP(20)")
            .ValueGeneratedOnUpdate();
    }


    public string TableName => "Posts";
}
    
