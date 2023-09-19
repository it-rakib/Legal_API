using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Domain.NopModel
{
    public partial class NOPDBContext : DbContext
    {
        public NOPDBContext()
        {
        }

        public NOPDBContext(DbContextOptions<NOPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttributeAttributeValMapping> AttributeAttributeValMappings { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandModelMapping> BrandModelMappings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<InventoryItemMappning> InventoryItemMappnings { get; set; }
        public virtual DbSet<InventoryReceive> InventoryReceives { get; set; }
        public virtual DbSet<InventoryReceiveDetail> InventoryReceiveDetails { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<ModelTagMapping> ModelTagMappings { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeAttributeValMapping>(entity =>
            {
                entity.HasKey(e => e.AttributeValueMappingId);

                entity.ToTable("AttributeAttributeValMapping");

                entity.HasOne(d => d.PoductAttribute)
                    .WithMany(p => p.AttributeAttributeValMappings)
                    .HasForeignKey(d => d.PoductAttributeId)
                    .HasConstraintName("FK_AttributeAttributeValMapping_ProductAttribute");

                entity.HasOne(d => d.ProductAttributeValue)
                    .WithMany(p => p.AttributeAttributeValMappings)
                    .HasForeignKey(d => d.ProductAttributeValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeAttributeValMapping_ProductAttributeValue");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<BrandModelMapping>(entity =>
            {
                entity.HasKey(e => e.BrandModelId)
                    .HasName("PK_Table_1");

                entity.ToTable("BrandModelMapping");

                entity.Property(e => e.BrandModelId).ValueGeneratedNever();

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.BrandModelMappings)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_BrandModelMapping_Brand");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.BrandModelMappings)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_BrandModelMapping_Model");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<InventoryItemMappning>(entity =>
            {
                entity.HasKey(e => e.InventoryItemMappnigId);

                entity.ToTable("InventoryItemMappning");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InventoryItemMappnings)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_InventoryItemMappning_Items");

                entity.HasOne(d => d.ReceivedDetail)
                    .WithMany(p => p.InventoryItemMappnings)
                    .HasForeignKey(d => d.ReceivedDetailId)
                    .HasConstraintName("FK_InventoryItemMappning_InventoryReceiveDetails");
            });

            modelBuilder.Entity<InventoryReceive>(entity =>
            {
                entity.HasKey(e => e.ReceiveId)
                    .HasName("PK__Inventor__3034B349CE0345DF");

                entity.ToTable("InventoryReceive");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryReceiveDetail>(entity =>
            {
                entity.HasKey(e => e.ReceivedDetailId);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.ToTable("Model");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ModelTagMapping>(entity =>
            {
                entity.HasKey(e => e.ModelTagMapId);

                entity.ToTable("ModelTagMapping");

                entity.Property(e => e.ModelTagMapId).ValueGeneratedNever();

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.ModelTagMappings)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_ModelTagMapping_Model");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ModelTagMappings)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ModelTagMapping_Tag");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Product__BrandId__6A30C649");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Product__Categor__6B24EA82");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK__Product__ModelId__6C190EBB");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.ToTable("ProductAttributeValue");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                entity.ToTable("Product_ProductAttribute_Mapping");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductAttributeId_ProductAttribute_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductAttribute_Mapping_Product1");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
