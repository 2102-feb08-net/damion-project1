﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data
{
    public partial class DamionBuyContext : DbContext
    {
        public DamionBuyContext()
        {
        }

        public DamionBuyContext(DbContextOptions<DamionBuyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreInventory> StoreInventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member");

                entity.HasIndex(e => e.Email, "UQ__Member__A9D1053498CA66BC")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DatePlaced).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__41A3B202");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Orders__StoreID__4297D63B");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Orderid).HasColumnName("ORDERID");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.Orderid)
                    .HasConstraintName("FK__OrderItem__ORDER__457442E6");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("FK__OrderItem__PRODU__4668671F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductDescription).HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProductPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("STORES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StoreLocationAddress)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StoreLocationCity)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StoreLocationCountry)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StoreLocationState)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StoreLocationZip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StorePhoneNumber)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<StoreInventory>(entity =>
            {
                entity.ToTable("STORE_INVENTORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StoreInventories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__STORE_INV__Produ__3AF6B473");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreInventories)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__STORE_INV__Store__3BEAD8AC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
