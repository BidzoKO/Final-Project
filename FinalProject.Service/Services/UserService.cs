using FinalProject.Core.Abstractions.Repositories;
using FinalProject.Core.Abstractions.Services;
using FinalProject.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Service.Services
{
	public class UserService : IUserService
	{

		private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Login(LoginCredentialsDto credentials)
        {
            var user = await _userRepository.Login(credentials) ?? throw new ArgumentNullException();

            return user.Id; 

        }

		public async Task<double> GetBalance(Guid id)
        {
            var balance = await _userRepository.GetBalance(id) ?? throw new ArgumentNullException();

            return balance;
        }

	}
}
