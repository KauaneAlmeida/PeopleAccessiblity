namespace DisabledPeopleRegister.Interfaces
{
    public interface IUsersRepository
    {
        void AddUser(string name, string username, string password);
    }
}
