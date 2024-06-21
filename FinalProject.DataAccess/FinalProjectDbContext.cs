using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FinalProject.Core.Models.Entities;

namespace FinalProject.DataAccess;

public partial class FinalProjectDbContext : DbContext
{
    public FinalProjectDbContext()
    {
    }

    public FinalProjectDbContext(DbContextOptions<FinalProjectDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=BPC;Database=FinalProject;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.Entity<Order>(entity =>
		{
			entity.Property(e => e.Id).ValueGeneratedNever();

			entity.HasOne(d => d.User).WithMany(p => p.Orders)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_order_user");

			entity.HasMany(d => d.OrderDetails).WithMany(p => p.Orders)
				.UsingEntity<Dictionary<string, object>>(
					"OrderDetailMap",
					r => r.HasOne<OrderDetail>().WithMany()
						.HasForeignKey("OrderDetailId")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("FK_order_detail_map_order_detail"),
					l => l.HasOne<Order>().WithMany()
						.HasForeignKey("OrderId")
						.OnDelete(DeleteBehavior.ClientSetNull)
						.HasConstraintName("FK_order_detail_map_order"),
					j =>
					{
						j.HasKey("OrderId", "OrderDetailId");
						j.ToTable("order_detail_map");
						j.HasIndex(new[] { "OrderDetailId" }, "IX_order_detail_map_order_detail_ID");
						j.IndexerProperty<Guid>("OrderId").HasColumnName("order_ID");
						j.IndexerProperty<Guid>("OrderDetailId").HasColumnName("order_detail_ID");
					});
		});

		modelBuilder.Entity<OrderDetail>(entity =>
		{
			entity.Property(e => e.Id).ValueGeneratedNever();

			entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_order_detail_product");
		});

		modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "apple",
                    Price = 5.5,
                    Quantity = 100,
                    Description = "Description",
                    Status = Core.Constants.ProductStatus.Available,
                },
				new Product()
				{
					Id = Guid.NewGuid(),
					Name = "banana",
					Price = 5.5,
					Quantity = 100,
					Description = "Description",
					Status = Core.Constants.ProductStatus.Available,
				},

				new Product()
				{
					Id = Guid.NewGuid(),
					Name = "grape",
					Price = 5.5,
					Quantity = 100,
					Description = "Description",
					Status = Core.Constants.ProductStatus.Available,
				},

				new Product()
				{
					Id = Guid.NewGuid(),
					Name = "bread",
					Price = 5.5,
					Quantity = 100,
					Description = "Description",
					Status = Core.Constants.ProductStatus.Available,
				}

				);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasData(
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Name",
                    LastName = "LastName",
                    Email = "Test@email.com",
                    PasswordHash = "12345678",
                    Balance = 1000
                }           
                );
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
