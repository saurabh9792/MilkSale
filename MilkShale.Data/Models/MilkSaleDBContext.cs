using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MilkShale.Data.Models
{
    public partial class MilkSaleDBContext : DbContext
    {
        public MilkSaleDBContext()
        {
        }

        public MilkSaleDBContext(DbContextOptions<MilkSaleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<LoginUser> LoginUser { get; set; }
        public virtual DbSet<PasswordResetLinkForUser> PasswordResetLinkForUser { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<TimeZoneList> TimeZoneList { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserModulePermission> UserModulePermission { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserSubscription> UserSubscription { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-L2HVSDDI;Database=MilkSaleDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoginUser>(entity =>
            {
                entity.Property(e => e.LastActivityOn).HasColumnType("datetime");

                entity.Property(e => e.PageName).HasMaxLength(300);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginUser_User");
            });

            modelBuilder.Entity<PasswordResetLinkForUser>(entity =>
            {
                entity.Property(e => e.LinkSentOn).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PasswordResetLinkForUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PasswordResetLinkForUser_User");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateName).HasMaxLength(50);
            });

            modelBuilder.Entity<TimeZoneList>(entity =>
            {
                entity.Property(e => e.CurrentUtcOffset)
                    .IsRequired()
                    .HasColumnName("current_utc_offset")
                    .HasMaxLength(6);

                entity.Property(e => e.IsCurrentlyDst).HasColumnName("is_currently_dst");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.ZoneId).HasMaxLength(4);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IpAddress).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LastPasswordChangedOn).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.SaltKey).HasMaxLength(100);

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserRole_User");
            });

            modelBuilder.Entity<UserModulePermission>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserModulePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModulePermission_UserRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserModulePermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModulePermission_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserSubscription>(entity =>
            {
                entity.Property(e => e.UserSubscriptionId).ValueGeneratedNever();

                entity.Property(e => e.CreateadOn).HasColumnType("datetime");

                entity.Property(e => e.PlanEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlanName).HasMaxLength(500);

                entity.Property(e => e.PlanStartDate).HasColumnType("datetime");

                entity.Property(e => e.PlanTypeName).HasMaxLength(300);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSubscription)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
