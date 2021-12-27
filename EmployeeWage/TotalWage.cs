using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public  class EmpWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private string company;
        private int EMP_RATE_PER_HR;
        private int MAX_HRS_IN_MONTH;
        private int totalEmpWage=0;
        private int NO_OF_WORKING_DAYS;

        public  EmpWageBuilder(string company, int EMP_RATE_PER_HR, int NO_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.company = company;
            this.EMP_RATE_PER_HR= EMP_RATE_PER_HR;
            this.NO_OF_WORKING_DAYS = NO_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }

        public void computeEmpWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalworkingdays = 0;


            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingdays <= NO_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    case IS_PART_TIME:

                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("DAY:" + totalworkingdays + " EmpHrs:" + empHrs);
            }
             totalEmpWage = totalEmpHrs * this.EMP_RATE_PER_HR;
          
       
         }
        public string tostring()
        {
            return "TOTAL EMPLOYEE WAGE FOR COMPANY: " + this.company + " is: " + this.totalEmpWage;

        }

    }
}
