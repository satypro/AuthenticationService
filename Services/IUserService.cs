using System.Threading.Tasks;
using AadharAuthService.Models;

namespace AadharAuthService.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(int userId);
    }
}