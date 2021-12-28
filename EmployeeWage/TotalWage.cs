using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public  class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numofcompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public  EmpWageBuilderArray()
        {
           this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int EMP_RATE_PER_HR, int NO_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            companyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, EMP_RATE_PER_HR, NO_OF_WORKING_DAYS, MAX_HRS_IN_MONTH);
            numofcompany++;
        }


        public void computeEmpWage()
        {
            for (int i = 0; i < numofcompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalworkingdays = 0;


            while (totalEmpHrs <= companyEmpWage.MAX_HRS_IN_MONTH && totalworkingdays <= companyEmpWage.NO_OF_WORKING_DAYS)
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
            return  totalEmpHrs = totalEmpHrs * companyEmpWage.EMP_RATE_PER_HR;
          
       
         }
     

    }
}
