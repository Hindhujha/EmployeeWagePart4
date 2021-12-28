using System;
namespace EmployeeWage
{
    class Program
    {
        
          
        static void Main(string[] args)
        {
            EmpWageBuilderArray company = new EmpWageBuilderArray();
            company.addCompanyEmpWage("DMART",20,20,100);
            company.addCompanyEmpWage("RELIANCE", 10, 22, 150);
            company.computeEmpWage();
        }
    }
}


