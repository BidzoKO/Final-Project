using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Abstractions.Services;
using FinalProject.Core.Models.Dtos;

namespace FinalProject.UI
{
	public partial class HomePage : Form
	{
		private readonly IProductService _productService; IUserService _userService;
		public HomePage(IProductService productService, IUserService userService)
		{
			_productService = productService;
			_userService = userService;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private async void Login_Click(object sender, EventArgs e)
		{
			try
			{
				var loginRequest = new LoginCredentialsDto
				{
					Email = textBox_email.Text,
					Password = textBox_password.Text
				};

				var userId = await _userService.Login(loginRequest);
				this.Hide();
				ShopForm form2 = new ShopForm(userId, _productService, _userService);
				form2.Show();				
			}
			catch (ArgumentNullException)
			{
				label_error.Text = "wrong credentials, try again";

				return;
			}
		}
	}
}
