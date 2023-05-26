public class UserRepository : IUserRepository
{
    private LinkedList<User> users;
    //Al parecer no funcionar guardarlos en memoria pero me toca seguir con el resto de ejercicios
    //Si tuviera mas tiempo lo corregiria.
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        if(users == null)
        {
            Console.WriteLine("users is null");
            users = new LinkedList<User>();
        }
        Console.WriteLine(users.Count);
        return users.ToList();
    }
    public async Task<String> CreateUserAsync(User user)
    {
        if(users == null)
        {
            users = new LinkedList<User>();
        }
        users.AddLast(user);
        Console.WriteLine(users.Count);
        return "User Created";
    }
}