using Exceptions_Homework.Models;
using Exceptions_Homework.Services.Interfaces;

namespace Exceptions_Homework.Services
{
    public class UserService : IUserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new() {
                    Id = 1,
                    FullName="Fatime Qayxanova",
                    Email="fatima@code.edu.az",
                    Password="fatime123"
                },
                new() {
                    Id = 1,
                    FullName="Fexriyye Tagizade",
                    Email="fexriyye@code.edu.az",
                    Password="fexriyye123"
                },
                new() {
                    Id = 1,
                    FullName="Afide Veliyeva",
                    Email="afide@code.edu.az",
                    Password="afide123"
                },
            };
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
