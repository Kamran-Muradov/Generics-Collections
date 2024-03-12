using Collections_Homework.Services.Interfaces;
using Exceptions_Homework.Helpers.Exceptions;
using Exceptions_Homework.Models;
using Exceptions_Homework.Services;
using Exceptions_Homework.Services.Interfaces;

namespace Collections_Homework.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserService _userService;

        public AccountService()
        {
            _userService = new UserService();
        }

        public bool SignIn(string email, string password)
        {
            User[] users = _userService.GetAll();

            User existUser = users.FirstOrDefault(m => m.Email == email && m.Password == password);

            return existUser is null ? throw new UserNotFoundException("User notfound") : true;
        }
    }
}
