using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ManegermentPond.Models;

public partial class QuanLyAoNuoiContext : DbContext
{
    public QuanLyAoNuoiContext()
    {
    }

    public QuanLyAoNuoiContext(DbContextOptions<QuanLyAoNuoiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillInfor> BillInfors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Pond> Ponds { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KHANHTIEN;Database=QuanLyAoNuoi;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC07B72D6EFB");

            entity.ToTable("Account");

            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'KhanhTien')");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasDefaultValueSql("(N'Customer')");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bill__3214EC07B46EF7C7");

            entity.ToTable("Bill");

            entity.Property(e => e.DateEnd).HasColumnType("date");
            entity.Property(e => e.DateStart)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");

            entity.HasOne(d => d.IdPondNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.IdPond)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bill__IdPond__32E0915F");
        });

        modelBuilder.Entity<BillInfor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BillInfo__3214EC07D529E2FE");

            entity.ToTable("BillInfor");

            entity.HasOne(d => d.IdBillNavigation).WithMany(p => p.BillInfors)
                .HasForeignKey(d => d.IdBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BillInfor__IdBil__35BCFE0A");

            entity.HasOne(d => d.IdCateNavigation).WithMany(p => p.BillInfors)
                .HasForeignKey(d => d.IdCate)
                .HasConstraintName("FK__BillInfor__IdCat__36B12243");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC07F28A3A69");

            entity.ToTable("Category");

            entity.Property(e => e.Decription).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Categories)
                .HasForeignKey(d => d.IdProd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Category__IdProd__2B3F6F97");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3214EC07B4D6BB67");

            entity.ToTable("Company");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Pond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pond__3214EC078A044E93");

            entity.ToTable("Pond");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Note).HasMaxLength(200);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC077F52C22B");

            entity.ToTable("Product");

            entity.Property(e => e.Cate).HasMaxLength(100);
            entity.Property(e => e.IdCpn).HasColumnName("IdCPN");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.IdCpnNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCpn)
                .HasConstraintName("FK__Product__IdCPN__286302EC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
