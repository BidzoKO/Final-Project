using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Abstractions.Services;
using FinalProject.Core.Models.Dtos;
using FinalProject.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Service.Services
{

	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
			_productRepository = productRepository;
		}

		public async Task<List<Product>> GetAllProducts()
		{
			var products = await _productRepository.GetAll();

			if (!products.Any())
			{
				throw new ArgumentNullException();
			}

			return products;
		}

		public async Task AddToCart(CartRequestDto request)
		{
			await _productRepository.AddToCart(request);
		}

		public async Task<List<OrderDetail>> GetCart()
		{
			var cart = await _productRepository.GetCart() ?? throw new ArgumentNullException();

			return cart.OrderDetails.ToList();
		}

		public async Task<Product> GetProduct(Guid id)
		{
			var product = await _productRepository.GetById(id) ?? throw new ArgumentNullException(); ;

			return product;
		}

		public async Task BuyCart(Guid userId)
		{
			var cart = await _productRepository.GetCart() ?? throw new ArgumentNullException();

			await _productRepository.BuyCart(cart, userId);
		}
    }
}
