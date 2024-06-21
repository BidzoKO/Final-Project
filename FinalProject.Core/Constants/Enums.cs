using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Constants
{
	public enum ProductStatus
	{
		Available,
		OutOfStock,
		Removed,
	}

	public enum OrderStatus
	{
		Open,
		Closed,
		Paid,
	}
}
