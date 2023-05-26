public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<String> CreateUserAsync(User user);
}