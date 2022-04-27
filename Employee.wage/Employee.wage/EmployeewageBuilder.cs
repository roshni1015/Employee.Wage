using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.wage
{
    public class EmployeewageBuilder
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        String company;
        int employeewageprhr;
        int employeeworkingdays;
        int maximumworkinghr;
        int totalemployeewage;

        public EmployeewageBuilder(string company, int employeewageprhr, int employeeworkingdays, int maximumworkinghr)
        {
            this.company = company;
            this.employeewageprhr = employeewageprhr;
            this.employeeworkingdays = employeeworkingdays;
            this.maximumworkinghr = maximumworkinghr;
        }
        public void Computeemployeewage()
        {
            //variables
            int employeehrs = 0, totalemployeehr = 0, totalworkingdays = 0;
            //computation 

            while (totalemployeehr <= this.maximumworkinghr && totalworkingdays < this.employeeworkingdays)
            {

                totalworkingdays++;
                Random emp = new Random();
                int empcheck = emp.Next(0, 3);
                switch (empcheck)
                {
                    case isPartTime:
                        employeehrs = 4;
                        break;
                    case isFullTime:
                        employeehrs = 8;
                        break;
                    default:
                        employeehrs = 0;
                        break;
                }
                totalemployeehr += employeehrs;
                Console.WriteLine("Day# : " + totalworkingdays + "EmpolyeeHrs: " + employeehrs);
            }
            int totalemployeewage = totalemployeehr * employeewageprhr;
            Console.WriteLine("Total Employee Wage for Company: " + company + " is: " + totalemployeewage);
        }
        public string ToString()
        {
            return "Total Employee Wage for Company: " + company + " is: " + totalemployeewage;

        }
    }

}
           
