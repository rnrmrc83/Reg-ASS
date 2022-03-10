using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopReg.Models
{
    public partial class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
        {
        }

        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PriceList> PriceLists { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<VProductSupplier> VProductSuppliers { get; set; } = null!;
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString01"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.ToTable("PriceList");

                entity.Property(e => e.CodeList).HasMaxLength(50);

                entity.Property(e => e.Discontinued).HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdDiscountType).HasMaxLength(5);

                entity.Property(e => e.IdProduct)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.ValueLimit)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.PriceLists)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceList_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdSupplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Supplier");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.Property(e => e.Category_Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('SH'+CONVERT([varchar](16),(1000)+[Id]))", false);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(70);
            });

            modelBuilder.Entity<VProductSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_product_supplier");

                entity.Property(e => e.Code)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Category_Name).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ShipTime).HasColumnName("ShipTIme");

                entity.Property(e => e.State).HasMaxLength(50);
            });

            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
