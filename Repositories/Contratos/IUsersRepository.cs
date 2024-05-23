using DisabledPeopleRegister.Dtos.Users;

namespace DisabledPeopleRegister.Repositories.Contracts
{
    public interface IUsersRepository
    {
        void AddUser(CreateUserDto createUserDto);

        bool UserExist(string username);

        bool CheckUserCredentials(LogUserDto logUserDto);
    }
}
