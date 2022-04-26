using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.wage
{
    public class TotalSalary
    {

        String company;
        int employeewageprhr = 20;
        int employeeworkinghr = 0;
        int employeeworkingdays = 0;
        int maximumworkinghr;
        int maximumworkingdays;

        public void Totalsalary(string company, int employeewageprhr, int maximumworkinghr, int maximumworkingdays)
        {

            Random emp = new Random();
            int isPresent = emp.Next(0, 4);
            Console.WriteLine(isPresent);
            if (isPresent == 1)
            {
                Console.WriteLine("Employee is present!");
                Console.WriteLine("Employee is Full Time");
            }
            else if (isPresent == 2)
            {
                Console.WriteLine("Employee is Present!");
                Console.WriteLine("Employee is Part Time");
            }

            else
            {
                Console.WriteLine("Employee is Absent!");
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
            Console.WriteLine("Total Salary of Employee per Month in {0} is {1} : ", company, totalSalary);
        }
    }
}


