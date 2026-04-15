using MyWebAPI.Core.Entities;
using MyWebAPI.Core.Interfaces;

namespace MyWebAPI.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        // 确保这个方法存在
        public async Task<User?> GetUserByIdAsync(string id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        // 其他方法...
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var users = await _userRepository.FindAsync(u => u.UserName == username);
            var user = users.FirstOrDefault();
            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> CreateUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user != null)
            {
                //user.IsDeleted = true;
                await _userRepository.UpdateAsync(user);
            }
        }

        public string GenerateJwtToken(User user)
        {
            // JWT token generation logic
            return "token";
        }
    }
}