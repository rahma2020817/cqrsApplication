﻿using Cqrs.demo.Domain.PostAggregate;
using Cqrs.demo.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cqrs.demo.Infrastructure.EntityTypeBuilder;

public class PostCommentEntityBuilder : IEntityTypeConfiguration<PostComment>, IEntityTableName
{
    public string TableName => "Comments";
    
    public void Configure(EntityTypeBuilder<PostComment> builder)
    {
        builder.ToTable(TableName);
        builder.HasKey(pc => pc.CommentId);
    }
    
}