using System.Threading.Tasks;
using AuthenticationService.Models;

namespace AuthenticationService.Services
{
    public class UserService : IUserService
    {
        public async Task<User> GetAsync(int userId)
        {
            var user = new User
            {
                    FirstName = "SatyPro",
                    LastName = "Singh",
                    Gender = "Male",
                    Age = 27,
                    Country = "hello"
            };

            return await Task.FromResult<User>(user);    
        }
    }
}