using Collections_Homework.Data;
using Collections_Homework.Models;
using Collections_Homework.Services.Interfaces;

namespace Collections_Homework.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int? id = null)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id);
        }

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m => m.Age == age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }

        public List<Customer> OrderByAge(string orderCondition)
        {
            List<Customer> orderedCustomers = new();

            switch (orderCondition.Trim().ToLower())
            {
                case "ascending":
                    orderedCustomers.AddRange(AppDbContext.customers.OrderBy(m => m.Age));
                    return orderedCustomers;

                case "descending":
                    orderedCustomers.AddRange(AppDbContext.customers.OrderByDescending(m => m.Age));
                    return orderedCustomers;

                default:
                    throw new ArgumentException("Invalid order condition");
            }
        }
    }
}
