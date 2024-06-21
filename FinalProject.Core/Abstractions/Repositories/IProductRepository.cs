using FinalProject.Core.Models.Dtos;
using FinalProject.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Abstractions.Repositories
{
	public interface IProductRepository
	{
		public Task<List<Product>> GetAll();
		public Task AddToCart(CartRequestDto request);
		public Task<Order?> GetCart();
		public Task<Product?> GetById(Guid id);
		public Task BuyCart(Order cart, Guid Id);

	}
}
