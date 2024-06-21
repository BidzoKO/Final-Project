using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Models.Dtos
{
	public class CartRequestDto
	{
		public Guid UserId { get; set; }
		public int Quantity { get; set; }
		public string ProductName { get; set; } = string.Empty;
	}
}
