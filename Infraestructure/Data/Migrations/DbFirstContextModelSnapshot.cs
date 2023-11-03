﻿// <auto-generated />
using System;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Data.Migrations
{
    [DbContext(typeof(DbFirstContext))]
    partial class DbFirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Core.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("driver", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Name" }, "Name_UNIQUE")
                        .IsUnique();

                    b.ToTable("team", (string)null);
                });

            modelBuilder.Entity("Teamdriver", b =>
                {
                    b.Property<int>("IdTeamFk")
                        .HasColumnType("int");

                    b.Property<int>("IdDriverFk")
                        .HasColumnType("int");

                    b.HasKey("IdTeamFk", "IdDriverFk")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdDriverFk" }, "IdDriverFk_idx");

                    b.ToTable("teamdriver", (string)null);
                });

            modelBuilder.Entity("Teamdriver", b =>
                {
                    b.HasOne("Core.Entities.Driver", null)
                        .WithMany()
                        .HasForeignKey("IdDriverFk")
                        .IsRequired()
                        .HasConstraintName("IdDriverFk");

                    b.HasOne("Core.Entities.Team", null)
                        .WithMany()
                        .HasForeignKey("IdTeamFk")
                        .IsRequired()
                        .HasConstraintName("IdTeamFk");
                });
#pragma warning restore 612, 618
        }
    }
}
