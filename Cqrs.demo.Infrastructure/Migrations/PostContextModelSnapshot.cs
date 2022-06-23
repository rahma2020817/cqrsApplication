﻿// <auto-generated />
using System;
using Cqrs.demo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cqrs.demo.Infrastructure.Migrations
{
    [DbContext(typeof(PostContext))]
    partial class PostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("PostId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Posts", (string)null);
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.PostComment", b =>
                {
                    b.Property<Guid>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uuid");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.PostInteraction", b =>
                {
                    b.Property<Guid>("InteractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<int>("InteractionType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastModified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP(20)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uuid");

                    b.HasKey("InteractionId");

                    b.HasIndex("PostId");

                    b.ToTable("Interactions", (string)null);
                });

            modelBuilder.Entity("Cqrs.demo.Domain.UserAggregate.UserProfile", b =>
                {
                    b.Property<Guid>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IdentityId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserProfileId");

                    b.ToTable("UserProfile", (string)null);
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.Post", b =>
                {
                    b.HasOne("Cqrs.demo.Domain.UserAggregate.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.PostComment", b =>
                {
                    b.HasOne("Cqrs.demo.Domain.PostAggregate.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.PostInteraction", b =>
                {
                    b.HasOne("Cqrs.demo.Domain.PostAggregate.Post", null)
                        .WithMany("Interactions")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cqrs.demo.Domain.UserAggregate.UserProfile", b =>
                {
                    b.OwnsOne("Cqrs.demo.Domain.UserAggregate.BasicInfo", "BasicInfo", b1 =>
                        {
                            b1.Property<Guid>("UserProfileId")
                                .HasColumnType("uuid");

                            b1.Property<string>("CurrentCity")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<DateTime>("DateOfBirth")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("UserProfileId");

                            b1.ToTable("UserProfile");

                            b1.WithOwner()
                                .HasForeignKey("UserProfileId");
                        });

                    b.Navigation("BasicInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("Cqrs.demo.Domain.PostAggregate.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Interactions");
                });
#pragma warning restore 612, 618
        }
    }
}
