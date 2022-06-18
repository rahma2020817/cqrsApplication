using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class PostInteractionEntityBuilder : IEntityTypeConfiguration<PostInteraction>, IEntityTableName
{
    public void Configure(EntityTypeBuilder<PostInteraction> builder)
    {
        builder.ToTable(TableName);
        builder.HasKey(pi => pi.InteractionId);
    }

    public string TableName => "Interactions";
}