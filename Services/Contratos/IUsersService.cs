using DisabledPeopleRegister.Dtos;
using DisabledPeopleRegister.Dtos.Users;
using DisabledPeopleRegister.Models;

namespace DisabledPeopleRegister.Services.Contracts
{
    public interface IUsersService
    {
        Usuario GetUserById(int id);

        void AddUser(CreateUserDto createUserDto);

        bool CheckUserCredentials(LogUserDto logUserDto);
    }
}