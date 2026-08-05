using AvaloniaWebAPI.Core.Entities;
using AvaloniaWebAPI.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace AvaloniaWebAPI.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly ILogger<UserService> _logger;

        public UserService(IRepository<User> userRepository, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<PlatformBasicDataResult<User>> GetUsersAsync()
        {
            try
            {
                _logger.LogInformation("开始获取所有用户");

                var users = await _userRepository.GetAllAsync();
                var userList = users.ToList();

                _logger.LogInformation($"获取用户成功，共 {userList.Count} 条记录");

                return new PlatformBasicDataResult<User>
                {
                    items = userList,
                    totalCount = userList.Count,
                    queryTime = DateTime.Now
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "获取用户失败");
                throw;
            }
        }

    }
}