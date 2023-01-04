using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppLong.Models;

public partial class QlnvContext : DbContext
{
    public QlnvContext()
    {
    }

    public QlnvContext(DbContextOptions<QlnvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QLNV;Trusted_Connection=True; encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.ToTable("NhanVien");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
