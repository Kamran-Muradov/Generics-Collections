using Exceptions_Homework.Services;

namespace Exceptions_Homework.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
      
    }
}
