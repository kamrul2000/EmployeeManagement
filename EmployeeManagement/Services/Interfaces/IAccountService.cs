using EmployeeManagement.Models;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IAccountService
    {
        Task<User?> AuthenticateAsync(string username, string password);
        Task<bool> RegisterAsync(User user);
        Task<User?> GetUserByNameAsync(string username);
    }
}
