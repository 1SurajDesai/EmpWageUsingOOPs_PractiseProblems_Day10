using System;
namespace EmployeeWageProblemWithObject
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program ");
            //EmployeeCheck empcheck = new EmployeeCheck();
            //.EmployeeAbsentOrPresent();
            EmpyeeWage empwage = new EmpyeeWage();
            empwage.CalculateEmpWage();

        }
    }
}