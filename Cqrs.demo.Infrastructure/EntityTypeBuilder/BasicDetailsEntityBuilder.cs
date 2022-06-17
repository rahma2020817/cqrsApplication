using Cqrs.demo.Domain.UserAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class BasicDetailsEntityBuilder : IEntityTypeConfiguration<BasicInfo>, IEntityTableName
{
    
public void Configure(EntityTypeBuilder<BasicInfo> builder)
{
    // builder.ToTable(TableName).HasKey(p => p.);
}


public string TableName => "Informations";

}