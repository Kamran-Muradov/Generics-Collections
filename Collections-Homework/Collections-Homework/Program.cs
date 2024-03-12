
using Collections_Homework.Controllers;
using Collections_Homework.Data;
using Collections_Homework.Models;
using Exceptions_Homework.Controllers;

//CalculationController calculationController = new CalculationController();

//calculationController.GetFactorial();

//foreach (var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

//AppDbContext.customers.Add(new Customer { FullName = "test" });

//foreach (var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

CustomerController customerController = new();

//customerController.GetAll();

//customerController.GetById();

//customerController.GetAllByAge();

//customerController.GetAllCountOfDatas();

customerController.OrderByAge();


