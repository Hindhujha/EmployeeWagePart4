using System;
namespace EmployeeWage
{
    class Program
    {
        
          
        static void Main(string[] args)
        {
            EmpWageBuilder company1=new EmpWageBuilder("DMART",20,20,100);
           EmpWageBuilder company2 = new EmpWageBuilder("RELIANCE", 10, 22, 150);
            company1.computeEmpWage();
            Console.WriteLine(company1.tostring());
            company2.computeEmpWage();
            Console.WriteLine(company2.tostring());
        }
    }
}


