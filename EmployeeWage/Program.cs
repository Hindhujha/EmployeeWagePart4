using System;
namespace EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void ComputeEmpWage()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION");

            int empHrs = 0, totalEmpHrs = 0, totalworkingdays = 0;


            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingdays < NO_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("TOTAL EMPLOYEE WAGE:" + totalEmpWage);
        }


         static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}


