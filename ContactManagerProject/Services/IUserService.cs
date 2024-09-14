using ContactManagerProject.Models;

namespace ContactManagerProject.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task UploadUsersAsync(IFormFile file);
        Task EditUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
