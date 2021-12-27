using System;
namespace EmployeeWage
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION");
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;

         

            Random random = new Random();
               int empcheck = random.Next(0, 2);
          
                if (empcheck == IS_FULL_TIME)
                {
                empHrs = 8;
                }
                else
                {
                empHrs = 0;
                }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("EMPLOYEE WAGE IS:" + empWage);
        }

        }
    }

