using exfive.Data;
using exfive.Interfaces.Users;
using exfive.Models;

namespace exfive.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<bool> CreateAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UserId == id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;


        }

        public IEnumerable<User> GelAllAsnyc()
        {
            var users = _dbContext.Users.ToList();

            if (users.Count > 0)
            {
                return users;
            }

            return new List<User>();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);

            if (user != null)
            {
                return user;
            }
            return new User();
        }

        public async Task<bool> UpdateAsync(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
