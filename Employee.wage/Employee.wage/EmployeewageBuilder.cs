using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.wage
{
    public class EmployeewageBuilder
    {

        String company;
        int totalsalary;
        int employeewageprhr = 20;
        int employeeworkinghr = 0;
        int employeeworkingdays = 0;
        int maximumworkinghr;
        int maximumworkingdays;

        public EmployeewageBuilder(string company, int employeewageprhr, int maximumworkinghr, int maximumworkingdays)
        {
            this.company = company;
            this.employeewageprhr = employeewageprhr;
            this.employeeworkingdays = employeeworkingdays;
            this.maximumworkinghr = maximumworkinghr;
        }

        public void salary()
        {

            Random emp = new Random();
            int isPresent = emp.Next(0, 4);
            Console.WriteLine(isPresent);
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is present!");
                Console.WriteLine("Employee is Full Time");
                employeeworkinghr = 8;
            }
            else if (isPresent == 2)
            {
                Console.WriteLine("Employee is Present!");
                Console.WriteLine("Employee is Part Time");
                employeeworkinghr = 4;
            }

            else
            {
                Console.WriteLine("Employee is Absent!");
                employeeworkinghr = 0;
            }


            while ((employeeworkinghr < maximumworkinghr) && (employeeworkingdays < maximumworkingdays))
            {

                switch (isPresent)
                {
                    case 1:
                        employeeworkinghr += 8;
                        break;
                    case 2:
                        employeeworkinghr += 4;
                        break;
                    case 0:
                        employeeworkinghr = 0;
                        break;
                    default:
                        break;

                }
                employeeworkingdays++;

            }
            Console.WriteLine("Total Working Hours : " + employeeworkinghr);
            Console.WriteLine("Total working Days Per Month : " + employeeworkingdays);
            int totalSalary = employeewageprhr * employeeworkinghr;
            Console.WriteLine("Total Salary of Employee per Month in {0} is {1}  ", company, totalSalary);
        }
        public string toString()
        {
            return "Total Employee Wage for Company : " + this.company + " is: " + this.totalsalary;
        }

    }
}
           
