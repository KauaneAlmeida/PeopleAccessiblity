using DisabledPeopleRegister.Dtos;
using DisabledPeopleRegister.Dtos.Users;
using DisabledPeopleRegister.Models;
using DisabledPeopleRegister.Repositories.Contracts;

namespace DisabledPeopleRegister.Repositories
{
    public class UserRepository(DatabaseContext databaseContext) : IUsersRepository
    {
        public void AddUser(CreateUserDto createUserDto)
        {
            Usuario userModel = new Usuario
            {
                Name = createUserDto.Name,
                Username = createUserDto.Username,
                Password = createUserDto.Password,
                Age = createUserDto.Age,
            };

            databaseContext.User.Add(userModel);
            databaseContext.SaveChanges();
        }

        public bool UserExist(string username)
        {
            var userModel = databaseContext.User.FirstOrDefault(user => user.Username == username);

            if (userModel is null)
            {
                return false;
            }

            return true;
        }

        public bool CheckUserCredentials(LogUserDto logUserDto)
        {
            var user = databaseContext.User.FirstOrDefault(user =>
                user.Username == logUserDto.Username && user.Password == logUserDto.Password);

            if (user is null)
            {
                return false;
            }

            return true;
        }
    }
}