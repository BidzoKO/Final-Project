using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Core.Models.Entities;

[Table("order_detail")]
public partial class OrderDetail
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("cost")]
    public double Cost { get; set; }

	[Column("product_ID")]
	public Guid ProductId { get; set; }

	[ForeignKey("ProductId")]
	[InverseProperty("OrderDetails")]
	public virtual Product Product { get; set; } = null!;

	[ForeignKey("OrderDetailId")]
    [InverseProperty("OrderDetails")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
