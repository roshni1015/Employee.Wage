// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage!");
int employeewageprhr = 20;
int employeeworkinghr;
Random emp = new Random();
int isPresent = emp.Next(0, 2);
Console.WriteLine(isPresent);


if (isPresent == 1)
{
    employeeworkinghr = 8;
    Console.WriteLine("Employee is Present");
}
else
{
    employeeworkinghr = 0;
    Console.WriteLine("Employee is Absent");
}
int EmployeeWage = employeewageprhr * employeeworkinghr;
Console.WriteLine("Employee wage = " + EmployeeWage);

