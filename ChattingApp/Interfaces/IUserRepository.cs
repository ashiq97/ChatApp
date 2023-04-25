using ChattingApp.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChattingApp.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByNameAsync(string name);
    }
}
