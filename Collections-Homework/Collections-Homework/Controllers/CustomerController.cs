using Collections_Homework.Data;
using Collections_Homework.Services;
using Collections_Homework.Services.Interfaces;

namespace Collections_Homework.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public void GetAll()
        {
            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }

        public void GetById()
        {
            try
            {
                //int id = 4;
                var result = _customerService.GetById();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetAllByAge()
        {
            int age = 21;

            foreach (var item in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }
        }

        public void GetAllCountOfDatas()
        {
            Console.WriteLine(_customerService.GetCount());
        }

        public void OrderByAge()
        {
            try
            {
                string condition = "descending";

                foreach (var item in _customerService.OrderByAge(condition))
                {
                    Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
