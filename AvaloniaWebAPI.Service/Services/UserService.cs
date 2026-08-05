using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;

namespace AvaloniaWebAPI.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

    }
}