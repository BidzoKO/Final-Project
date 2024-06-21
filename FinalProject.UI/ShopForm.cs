using Accessibility;
using FinalProject.Core.Abstractions.Services;
using FinalProject.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.UI
{
	public partial class ShopForm : Form
	{
		private readonly IProductService _productService; IUserService _userService;

		public ShopForm(Guid Id, IProductService productService, IUserService userService)
		{
			_productService = productService;
			InitializeComponent();
			User_Id.Text = Id.ToString();
			_userService = userService;
		}

		private async void ShopForm_Load(object sender, EventArgs e)
		{
			var products = await _productService.GetAllProducts();

			foreach (var product in products)
			{
				listBox_Products.Items.Add(Name = product.Name);
			}

			var balance = await _userService.GetBalance(Guid.Parse(User_Id.Text));

			textBox_Balance.Text = balance.ToString();
		}

		private void listBox_Products_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private async void button_add_to_cart_Click(object sender, EventArgs e)
		{
			listBox_Cart.Items.Clear();

			var addRequest = new CartRequestDto()
			{
				UserId = Guid.Parse(User_Id.Text),
				Quantity = (int)numericUpDown_quantity.Value,
				ProductName = listBox_Products.SelectedItem.ToString(),
			};

			await _productService.AddToCart(addRequest);

			var cartItems = await _productService.GetCart();

			foreach (var cartItem in cartItems)
			{
				var product = await _productService.GetProduct(cartItem.ProductId);

				var formattedString = $"Product = {product.Name} | Quantity : {cartItem.Quantity}";
				listBox_Cart.Items.Add(formattedString);
			}

			textBox_Total.Text = cartItems.Sum(c => c.Cost).ToString();
		}

		private void listBox_Cart_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private async void button_Buy_Click(object sender, EventArgs e)
		{
			listBox_Cart.Items.Clear();

			await _productService.BuyCart(Guid.Parse(User_Id.Text));

			textBox_Total.Text = 0.ToString();

			var balance = await _userService.GetBalance(Guid.Parse(User_Id.Text));

			textBox_Balance.Text = balance.ToString();

		}
	}
}
