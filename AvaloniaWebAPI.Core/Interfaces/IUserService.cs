using AvaloniaWebAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaWebAPI.Core.Interfaces
{
    public  interface IUserService
    {
        Task<User?> GetUserByIdAsync(string id);

        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
