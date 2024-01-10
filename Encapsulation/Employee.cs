using System.Text;
using System.Threading .Tasks;

namespace Encapsulation
{
    internal class Employee
    {
        // Automatic Property {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal BasicSalary { get; set; }
        public int TaxPercentage { get; set; }
    }
}
