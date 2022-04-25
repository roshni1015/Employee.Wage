// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage!");
Random emp = new Random();
int isPresent = emp.Next(0, 2);
Console.WriteLine(isPresent);
if (isPresent == 1)
    Console.WriteLine("Employee is Present");
else
    Console.WriteLine("Employee is Absent");
