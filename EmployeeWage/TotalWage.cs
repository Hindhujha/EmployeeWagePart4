using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
   public  class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public  LinkedList<CompanyEmpWage> companyEmpWageList;
        public Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

      
        public  EmpWageBuilder()
        {
           this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int EMP_RATE_PER_HR, int NO_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            CompanyEmpWage companyEmpwage =  new CompanyEmpWage(company, EMP_RATE_PER_HR, NO_OF_WORKING_DAYS, MAX_HRS_IN_MONTH);
            this.companyEmpWageList.AddLast(companyEmpwage);
            this.companyToEmpWageMap.Add(company, companyEmpwage);
        }


        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
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
            return totalEmpHrs = totalEmpHrs * companyEmpWage.EMP_RATE_PER_HR;


        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }



    }
     

    }

