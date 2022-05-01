﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.wage
{
    public class CompanyEmpWage
    {
        public String company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHourPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
            this.totalEmpWage = totalEmpWage;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {

            this.totalEmpWage = totalEmpWage;

        }
        public string ToString()
        {
            return "Total Emp Wage For Company : " + this.company + " is: " + this.totalEmpWage;

        }
    }
}