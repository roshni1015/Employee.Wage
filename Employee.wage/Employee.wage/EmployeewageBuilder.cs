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

        int numofcompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmployeewageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];

        }
        public void AddcompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHourPerMonth)
        {
            companyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, empRatePerHour, numofWorkingDays, maxHourPerMonth);
            numofcompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numofcompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());

            }
        }
        private int computeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            while (totalEmpHrs <= CompanyEmpWage.maxHourPerMonth && totalworkingDays < CompanyEmpWage.numofWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                        break;
                    case isFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingDays + "Employee Hours: " + empHrs);
            }
            return totalEmpHrs * CompanyEmpWage.empRatePerHour;

        }
    }
}

       

     