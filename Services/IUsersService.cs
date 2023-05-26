public interface IUsersService {
    Task<IEnumerable<User>> GetUsersAsync();
    Task<String> CreateUserAsync(User user);
}