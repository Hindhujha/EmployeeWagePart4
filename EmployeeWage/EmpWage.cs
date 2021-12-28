using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{


    public class CompanyEmpWage
    {
        public int EMP_RATE_PER_HR;
        public int MAX_HRS_IN_MONTH;
        public int totalEmpWage;
        public int NO_OF_WORKING_DAYS;
        public string company;

        public CompanyEmpWage(string company, int EMP_RATE_PER_HR, int NO_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HR = EMP_RATE_PER_HR;
            this.NO_OF_WORKING_DAYS = NO_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage= totalEmpWage;
        }

        public string tostring()
        {
            return "TOTAL EMPLOYEE WAGE FOR COMPANY: " + this.company + " is: " + this.totalEmpWage;
        }
    }

    
}
