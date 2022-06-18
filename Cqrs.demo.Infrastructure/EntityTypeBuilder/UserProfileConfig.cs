using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class UserProfileConfig : IEntityTypeConfiguration<UserProfile>, IEntityTableName
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.ToTable(TableName);
        builder.OwnsOne(up => up.BasicInfo);
    }

    public string TableName => "UserProfile";
}