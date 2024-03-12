using Exceptions_Homework.Models;

namespace Exceptions_Homework.Services.Interfaces
{
    public interface IUserService
    {
        User[] GetAll();
        User GetById(int id);
        void Delete(int id);
    }
}
