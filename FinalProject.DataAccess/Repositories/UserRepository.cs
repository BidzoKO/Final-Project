using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Models.Dtos;
using FinalProject.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess.Repositories
{
	public class UserRepository : IUserRepository
	{

		private readonly FinalProjectDbContext _finalProjectDbContext;

		public UserRepository( FinalProjectDbContext finalProjectDbContext)
		{
			_finalProjectDbContext = finalProjectDbContext;
		}

		public async Task<User?> Login(LoginCredentialsDto credentials)
		{
			var user = await _finalProjectDbContext.Users.FirstOrDefaultAsync(c => c.Email == credentials.Email);

			if (user is null || user.PasswordHash != credentials.Password)
			{
				return user;
			}

			return user;
		}

		public async Task<double?> GetBalance(Guid id)
		{
			var user = await _finalProjectDbContext.Users.FirstOrDefaultAsync(c => c.Id == id);

			if (user is null)
			{
				return null;
			}

			return user.Balance;
		}


	}
}
