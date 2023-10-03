using exfive.Data;
using exfive.Models;
using exfive.Repository;
using Npgsql.Internal;

Console.WriteLine("Hello, Bahriddin!");


User user = new User()
{
    UserId = 1,
    FirsName = "Bahriddin",
    LastName = "Abdusalomov",
    Email = "bahriddin@gmail.com",
    UserName = "bahriddin01",
    Password = "bahriddin0404"
};

UserRepository userRepository = new UserRepository(new AppDbContext());

bool result = await userRepository.CreateAsync(user);
Console.WriteLine(result);