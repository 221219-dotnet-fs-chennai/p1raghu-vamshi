using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityApi.Entities;

public partial class AssociatesDbContext : DbContext
{
    public AssociatesDbContext()
    {
    }

    public AssociatesDbContext(DbContextOptions<AssociatesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:associateserver.database.windows.net,1433;Initial Catalog=AssociatesDb;Persist Security Info=False;User ID=associate;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.PhoneNumber).HasName("PK__Address__85FB4E395EBB9616");

            entity.ToTable("Address", "Raghu");

            entity.Property(e => e.PhoneNumber).ValueGeneratedNever();
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Pincode).HasColumnName("pincode");
            entity.Property(e => e.UserAddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("userAddress");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Address__pincode__379037E3");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971CACAE6EAC49");

            entity.ToTable("Company", "Raghu");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CompanyEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CompanyLocation)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Website)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Companies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Company__userId__34B3CB38");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.RollNo).HasName("PK__Educatio__7886D5A0934A570A");

            entity.ToTable("Education", "Raghu");

            entity.Property(e => e.RollNo).ValueGeneratedNever();
            entity.Property(e => e.Grade)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("grade");
            entity.Property(e => e.Specialization)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Ug)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("UG");
            entity.Property(e => e.University)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Educations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Education__userI__43F60EC8");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("PK__Skills__DFA091876F92B270");

            entity.ToTable("Skills", "Raghu");

            entity.Property(e => e.SkillId).ValueGeneratedNever();
            entity.Property(e => e.SkillName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Skills)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Skills__userId__52442E1F");
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserDeta__CB9A1CFFFC037801");

            entity.ToTable("UserDetails", "Raghu");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Salutation)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
