using FinalProject.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Abstractions.Services
{
	public interface IUserService
	{
		public Task<Guid> Login(LoginCredentialsDto credentials);
		public Task<double> GetBalance(Guid id);

	}
}
