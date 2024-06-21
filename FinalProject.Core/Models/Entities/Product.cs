using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FinalProject.Core.Constants;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Core.Models.Entities;

[Table("product")]
public partial class Product
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("price")]
    public double Price { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("description")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("status")]
    public ProductStatus Status { get; set; }

	[InverseProperty("Product")]
	public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
