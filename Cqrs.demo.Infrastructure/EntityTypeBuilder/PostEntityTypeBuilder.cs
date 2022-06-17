using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class PostEntityTypeBuilder : IEntityTypeConfiguration<Post>, IEntityTableName
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable(TableName).HasKey(p => p.PostId);
    }


    public string TableName => "Posts";
}
    
