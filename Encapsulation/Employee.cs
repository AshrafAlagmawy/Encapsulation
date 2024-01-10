using System.Text;
using System.Threading .Tasks;

/*
 * The Main Goal Of Encapsulation 
 
1. Hide Internal Details:
    Encapsulation allows the bundling of data and methods within a class, hiding the internal details of an object and exposing only what is necessary.

2. Data Hiding:
    It provides a mechanism for hiding the implementation details of a class, enhancing security and reducing the risk of unintended interference.

3. Modularity:
    Encapsulation promotes code modularity by organizing code into self-contained units (classes), making it easier to manage and maintain.

4. Abstraction:
    It offers a level of abstraction by defining a clear interface for interacting with objects, allowing users to work with objects without needing to understand
    their internal workings.

5. Code Organization:
    Encapsulation improves code organization by grouping attributes and methods related to a specific object within a class, enhancing code readability and
    maintainability.

6. Flexibility and Maintainability:
    It allows for changes to the internal implementation of a class without affecting external code, improving flexibility and making code easier to maintain and extend.
 */


namespace Encapsulation
{
    internal class Employee
    {
        // Automatic Property {get; set;}
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public decimal BasicSalary { get; private set; }
        public int TaxPercentage { get; private set; }

        public void SetName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Please, Enter Your Full Name First And Last Name");
            FirstName = firstName;
            LastName = lastName;
        }
        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1986, 9, 17))
                throw new ArgumentException("Invalid Birth Date !");
            BirthDate = birthDate;
        }
        public void SetBasicSalary(decimal salary)
        {
            if (salary < 0)
                throw new ArgumentException("Invalid Value Of Salary");
            BasicSalary = salary;
        }
        public void SetTaxPercentage(int taxPercentage)
        {
            if (taxPercentage > 40 || taxPercentage < 10)
                throw new ArgumentException("Invalid Percentage Of Tax Percentage");
            TaxPercentage = taxPercentage;
        }
     
    }
}