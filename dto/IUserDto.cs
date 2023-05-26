public interface IUserDto
{
    IEnumerable<User> getUsers { get;}
    String setUser(User user);
}