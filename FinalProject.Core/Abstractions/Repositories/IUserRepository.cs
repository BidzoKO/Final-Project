using FinalProject.Core.Models.Dtos;
using FinalProject.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Core.Abstractions.Repositories
{
	public interface IUserRepository
	{
		public Task<User?> Login(LoginCredentialsDto credentials);
		public Task<double?> GetBalance(Guid id);
	}
}
