using DisabledPeopleRegister.Models;

namespace DisabledPeopleRegister.Interfaces
{
    public interface IUsersService
    {
        Usuario GetUserById(int id);

        void AddUser(string name, string username, string password);
    }
}
