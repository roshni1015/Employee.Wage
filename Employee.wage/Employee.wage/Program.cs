using Employee.wage;

Console.WriteLine("Welcome to Employee Wage!");
EmployeewageBuilder Employeewage = new EmployeewageBuilder();
Employeewage.AddcompanyEmpWage("Infosys", 10, 4, 20);
Employeewage.AddcompanyEmpWage("TCS", 10, 4, 20);
Employeewage.computeEmpWage();
