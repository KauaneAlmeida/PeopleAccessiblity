namespace DisabledPeopleRegister.Dtos.Users;

public class CreateUserDto
{
    public string Username { get; set; } = string.Empty;
    
    public string Password { get; set; } = string.Empty;
    
    public string Name { get; set; } = string.Empty; 
    
    public int Age { get; set; }
}