using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FinalProject.Core.Constants;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Core.Models.Entities;

[Table("order")]
public partial class Order
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("user_ID")]
    public Guid UserId { get; set; }

    [Column("status")]
    public OrderStatus Status { get; set; }

    [Column("total")]
    public double Total { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Orders")]
    public virtual User User { get; set; } = null!;

    [ForeignKey("OrderId")]
    [InverseProperty("Orders")]
	public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
