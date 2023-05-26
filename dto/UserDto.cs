public class UserDto : IUserDto
{
    private readonly IUserRepository _userRepository;

    public UserDto(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    //Como implementar una conexión real a base de datos toma tiempo vamos a manejarlo en memoria.
    public IEnumerable<User> getUsers { 
        get
        {
            return _userRepository.GetUsersAsync().Result;
        }
    }

    public String setUser(User user)
    {
        return _userRepository.CreateUserAsync(user).Result;
    }
}