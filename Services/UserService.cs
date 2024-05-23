using DisabledPeopleRegister.Dtos;
using DisabledPeopleRegister.Dtos.Users;
using DisabledPeopleRegister.Models;
using DisabledPeopleRegister.Repositories.Contracts;
using DisabledPeopleRegister.Services.Contracts;

namespace DisabledPeopleRegister.Services
{
    public class UserService(IUsersRepository usersRepository) : IUsersService
    {
        public void AddUser(CreateUserDto createUserDto)
        {
            //verificar se o usuário já existe
            if (usersRepository.UserExist(createUserDto.Username) == false)
            {
                usersRepository.AddUser(createUserDto);
            }
        }

        public bool CheckUserCredentials(LogUserDto logUserDto)
        {
            return usersRepository.CheckUserCredentials(logUserDto);
        }

        public Usuario GetUserById(int id)
        {
            return new Usuario { Id = id };
        }
    }
}