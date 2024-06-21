using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Models;
using FinalProject.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using FinalProject.Core.Models.Dtos;

namespace FinalProject.DataAccess.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly FinalProjectDbContext _finalProjectDbContext;

        public ProductRepository(FinalProjectDbContext dbContext)
        {
			_finalProjectDbContext = dbContext;
        }

		public async Task<List<Product>> GetAll()
		{
			var products = await _finalProjectDbContext.Products.ToListAsync();

			return products;
		}

		public async Task AddToCart(CartRequestDto request)
		{
			var cart = await _finalProjectDbContext.Orders
				.Include(c => c.OrderDetails)
				.FirstOrDefaultAsync(c => c.Status == OrderStatus.Open);

			var product = await _finalProjectDbContext.Products
				.FirstOrDefaultAsync(c => c.Name == request.ProductName);

			if (cart is null)
			{
				var newCart = new Order()
				{
					Id = Guid.NewGuid(),
					UserId = request.UserId,
					Status = OrderStatus.Open,
					Total = 0,
				};

				await _finalProjectDbContext.Orders.AddAsync(newCart);

				cart = newCart;
			}

			var newCartItem = new OrderDetail()
			{
				Id = Guid.NewGuid(),
				Quantity = request.Quantity,
				Cost = request.Quantity * product!.Price,
				ProductId = product.Id,
			};

			if (newCartItem.Quantity > 0)
			{
				cart.OrderDetails.Add(newCartItem);
				cart.Total = cart.Total + newCartItem.Cost;
			}

			await _finalProjectDbContext.SaveChangesAsync();
		}

		public async Task<Order?> GetCart()
		{
			var cart = await _finalProjectDbContext.Orders
				.Include(c => c.OrderDetails)
				.FirstOrDefaultAsync(c => c.Status == OrderStatus.Open);

			if (cart is null)
			{
				return cart;
			}

			return cart;
		}

		public async Task<Product?> GetById(Guid id)
		{
			return await _finalProjectDbContext.Products.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task BuyCart(Order cart, Guid Id)
		{
			var totalCost = cart.OrderDetails.Sum(c => c.Cost);

			var user = await _finalProjectDbContext.Users.FirstOrDefaultAsync(c => c.Id == Id);

			if (user is null || user.Balance < totalCost || cart.OrderDetails.Count == 0)
			{
				return;
			}

			cart.Status = OrderStatus.Paid;

			user.Balance = user.Balance - totalCost;

			await _finalProjectDbContext.SaveChangesAsync();
		}
	}
}
