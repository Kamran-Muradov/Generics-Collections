using Collections_Homework.Helpers.Constants;
using Collections_Homework.Services;
using Collections_Homework.Services.Interfaces;
using Exceptions_Homework.Helpers.Exceptions;
using System.Runtime.Serialization;

namespace Collections_Homework.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void SignIn()
        {
            string email = "test@gmail.com";
            string password = "fatime123";

            try
            {
                if (!email.Contains('@'))
                {
                    throw new InvalidEmailException(ResponseMessages.EmailFormat);
                }

                bool response = _accountService.SignIn(email, password);
                if (response)
                    Console.WriteLine("Sign in success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
