using Encapsulation;

var employee = new Employee();
employee.FirstName = "Ashraf";
employee.LastName = "Alagmawy";
employee.BirthDate = new DateOnly(2001, 12, 21);
employee.BasicSalary = 5000;
employee.TaxPercentage = 140;

Console.WriteLine($"Full Name:\t{employee.FirstName} {employee.LastName}");
Console.WriteLine($"Birth Date:\t{employee.BirthDate}");
Console.WriteLine($"Basic Salary:\t{employee.BasicSalary}");
Console.WriteLine($"Tax Percentage:\t{employee.TaxPercentage}");
Console.ReadKey();