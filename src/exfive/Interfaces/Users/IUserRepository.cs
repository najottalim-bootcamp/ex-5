using exfive.Models;

namespace exfive.Interfaces.Users;

public interface IUserRepository
{
    public Task<User> GetByIdAsync(int id);

    public IEnumerable<User> GelAllAsnyc();

    public Task<bool> CreateAsync(User user);

    public Task<bool> UpdateAsync(User user);

    public Task<bool> DeleteAsync(int id);
}