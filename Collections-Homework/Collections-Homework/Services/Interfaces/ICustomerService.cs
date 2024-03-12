using Collections_Homework.Models;

namespace Collections_Homework.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id = null);
        List<Customer> GetAllByAge(int age);
        int GetCount();
        List<Customer> OrderByAge(string condition);
    }
}
