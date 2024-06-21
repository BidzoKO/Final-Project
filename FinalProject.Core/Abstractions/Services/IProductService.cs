using FinalProject.Core.Models.Dtos;
using FinalProject.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Abstractions.Services
{
	public interface IProductService
	{
		public Task<List<Product>> GetAllProducts();
		public Task AddToCart(CartRequestDto request);
		public Task<List<OrderDetail>> GetCart();
		public Task<Product> GetProduct(Guid id);
		public Task BuyCart(Guid userId);
	}
}
