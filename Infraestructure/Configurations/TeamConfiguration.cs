using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("team");

            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.HasIndex(e => e.Name, "Name_UNIQUE").IsUnique();

            builder.Property(e => e.Name).HasMaxLength(50);


            builder
             .HasMany(p => p.Drivers)
             .WithMany(r => r.Teams)
             .UsingEntity<DriverTeam>(

                 j => j
                 .HasOne(pt => pt.Driver)
                 .WithMany(t => t.DriverTeams)
                 .HasForeignKey(ut => ut.IdDriverFk),


                 j => j
                 .HasOne(et => et.Team)
                 .WithMany(et => et.DriverTeams)
                 .HasForeignKey(el => el.IdTeamFk),

                 j =>
                 {
                     j.ToTable("DriverTeam");
                     j.HasKey(t => new { t.IdDriverFk, t.IdTeamFk });

                 });


            builder.HasMany(d => d.Drivers).WithMany(p => p.Teams)
                .UsingEntity<Dictionary<string, object>>(
                    "Teamdriver",
                    r => r.HasOne<Driver>().WithMany()
                        .HasForeignKey("IdDriverFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("IdDriverFk"),
                    l => l.HasOne<Team>().WithMany()
                        .HasForeignKey("IdTeamFk")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("IdTeamFk"),
                    j =>
                    {
                        j.HasKey("IdTeamFk", "IdDriverFk")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("teamdriver");
                        j.HasIndex(new[] { "IdDriverFk" }, "IdDriverFk_idx");
                    });
        }
    }
}