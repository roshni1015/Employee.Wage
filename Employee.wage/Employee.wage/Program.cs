// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage!");
int employeewageprhr = 20;
int employeeworkinghr = 0;
int employeeworkingdays = 20;
Random emp = new Random();
int isPresent = emp.Next(0, 4);
Console.WriteLine(isPresent);


switch (isPresent)
{
    case 1:
        Console.WriteLine("Employee is Present and FullTime!");
        employeeworkinghr = 8;
        break;
    case 2:
        Console.WriteLine("Employee is Present and PartTime!");
        employeeworkinghr = 4;
        break;
    case 0:
        Console.WriteLine("Employee is Absent!");
        employeeworkinghr = 0;
        break;
    default:
        Console.WriteLine("wrong input!");
        break;

}
int EmployeeWage = employeewageprhr * employeeworkinghr;
int EmployeeMonthlysalary = EmployeeWage * employeeworkingdays;
Console.WriteLine("Employee Daily Wage = " + EmployeeWage);
Console.WriteLine("Employee Monthly Wage = " + EmployeeMonthlysalary);


