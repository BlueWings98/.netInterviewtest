public class UsersService : IUsersService
{
    private readonly IUserDto _userDto;
    public UsersService(IUserDto userDto)
    {
        _userDto = userDto;
    }
    public Task<String> CreateUserAsync(User user)
    {
        return Task.FromResult(_userDto.setUser(user));
    }

    public Task<IEnumerable<User>> GetUsersAsync()
    {
        return Task.FromResult(_userDto.getUsers);
    }
}