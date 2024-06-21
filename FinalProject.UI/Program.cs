using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Abstractions.Services;
using FinalProject.DataAccess;
using FinalProject.DataAccess.Repositories;
using FinalProject.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FinalProject.UI
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();

			var serviceProvider = ConfigureServices();

			var mainForm = serviceProvider.GetRequiredService<HomePage>();

			Application.Run(mainForm);
		}

		private static ServiceProvider ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddDbContext<FinalProjectDbContext>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IProductService, ProductService>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IUserService, UserService>();

			services.AddScoped<HomePage>();

			return services.BuildServiceProvider();
		}
	}
}