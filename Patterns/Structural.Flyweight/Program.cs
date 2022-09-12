using Structural.Flyweight;

string empType = "FullTime";
var factory = new EmployeeTaxFactory();
var employeeTax = factory.GetEmployeeTaxBracket(empType);
employeeTax.DisplayTaxBracket();
empType = "PartTime";
employeeTax = factory.GetEmployeeTaxBracket(empType);
employeeTax.DisplayTaxBracket();
empType = "FullTime";
employeeTax = factory.GetEmployeeTaxBracket(empType);
employeeTax.DisplayTaxBracket();
Console.ReadKey();