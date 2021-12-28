using System;
namespace EmployeeWage
{
    class Program
    {
        
          
        static void Main(string[] args)
        {
            EmpWageBuilder company = new EmpWageBuilder();
            company.addCompanyEmpWage("DMART",20,20,100);
            company.addCompanyEmpWage("RELIANCE", 10, 22, 150);
            company.ComputeEmpWage();
            Console.WriteLine("TOTAL WAGE FOR DMART COMPANY: " + company.getTotalWage("DMART"));
            Console.WriteLine("TOTAL WAGE FOR RELIANCE COMPANY: " + company.getTotalWage("RELIANCE"));

        }
    }
}


