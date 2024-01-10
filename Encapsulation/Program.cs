using Encapsulation;

var employee = new Employee();

//employee.FirstName = "Ashraf";
//employee.LastName = "Alagmawy";
//employee.BirthDate = new DateOnly(2001, 12, 21);
//employee.BasicSalary = 5000;
//employee.TaxPercentage = 140;

//Console.WriteLine($"Full Name:\t{employee.FirstName} {employee.LastName}");
//Console.WriteLine($"Birth Date:\t{employee.BirthDate}");
//Console.WriteLine($"Basic Salary:\t{employee.BasicSalary}");
//Console.WriteLine($"Tax Percentage:\t{employee.TaxPercentage}");

//employee.SetBirthDate(new DateOnly(1985, 12, 21));
//Console.WriteLine($"Birth Date:\t{employee.BirthDate}");

//employee.FirstName = "Ashraf"; Can't Access To The Value Of It Because It's Private On The Set Value

employee.SetName("Ashraf","Alagmawy");
employee.SetBirthDate(new DateOnly(2001, 12, 21));
employee.SetBasicSalary(5000);
employee.SetTaxPercentage(10);

Console.WriteLine($"First Name:\t{employee.FirstName}");
Console.WriteLine($"Last Name:\t{employee.LastName}");
Console.WriteLine($"Birth Date:\t{employee.BirthDate}");
Console.WriteLine($"Basic Salary:\t{employee.BasicSalary}");
Console.WriteLine($"TaxPercentage:\t{employee.TaxPercentage}");

Console.ReadKey();
