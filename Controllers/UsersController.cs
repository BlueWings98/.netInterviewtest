using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers;

[ApiController]
[Route("/users")]
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;
    private readonly IUsersService _usersService;

    public UsersController(ILogger<UsersController> logger, IUsersService usersService)
    {
        _logger = logger;
        _usersService = usersService;
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> Get()
    {
        return _usersService.GetUsersAsync().Result;
    }
    [HttpPost(Name = "PostUser")]
    public Task<String> Post([FromBody] User user)
    {
        return _usersService.CreateUserAsync(user);
    }
}
