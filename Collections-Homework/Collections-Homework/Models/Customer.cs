using Exceptions_Homework.Models;

namespace Collections_Homework.Models
{
    public class Customer : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
