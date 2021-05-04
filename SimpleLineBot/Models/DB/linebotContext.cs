using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SimpleLineBot.Models.DB
{
    public partial class linebotContext : DbContext
    {
        public linebotContext()
        {
        }

        public linebotContext(DbContextOptions<linebotContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bot> Bots { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }

  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bot>(entity =>
            {
                entity.HasIndex(e => e.UId, "fk_uid");

                entity.HasIndex(e => e.ChannelAccessToken, "unique_channel_access_token")
                    .IsUnique();

                entity.HasIndex(e => e.ChannelSecret, "unique_channel_secret")
                    .IsUnique();

                entity.HasIndex(e => e.UrlToken, "unique_url_token")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.UId }, "unique_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ChannelAccessToken)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("channel_access_token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlToken)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("url_token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChannelSecret)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("channel_secret")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Enable)
                    .IsRequired()
                    .HasColumnName("enable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsBan).HasColumnName("is_ban");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("remarks")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UId)
                    .HasColumnType("int(11)")
                    .HasColumnName("u_id");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.HasOne(d => d.UIdNavigation)
                    .WithMany(p => p.Bots)
                    .HasForeignKey(d => d.UId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uid");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("group");

                entity.HasIndex(e => e.Name, "unique_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("remarks")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.GId, "fk_gid");

                entity.HasIndex(e => new { e.Email, e.GId }, "unique_email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enable)
                    .IsRequired()
                    .HasColumnName("enable")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GId)
                    .HasColumnType("int(11)")
                    .HasColumnName("g_id");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("remarks")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.HasOne(d => d.GIdNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.GId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_gid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public override int SaveChanges()
        {
            try
            {
                AddAuitInfo();
                return base.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public async System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            try
            {
                AddAuitInfo();
                return await base.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

        }

        private void AddAuitInfo()
        {
            var entries = base.ChangeTracker.Entries()
                .Where(x => x.Entity is ITimeLogger && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((ITimeLogger)entry.Entity).Created = DateTime.UtcNow;
                }
                ((ITimeLogger)entry.Entity).Updated = DateTime.UtcNow;
            }
        }
    }
}
