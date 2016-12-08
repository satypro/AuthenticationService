using System.Threading.Tasks;
using AuthenticationService.Models;

namespace AuthenticationService.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(int userId);
    }
}