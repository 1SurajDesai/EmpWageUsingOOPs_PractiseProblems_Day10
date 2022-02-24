using System;
namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program ");
            EmployeeCheck empcheck = new EmployeeCheck();
            empcheck.EmployeeAbsentOrPresent();
            

        }
    }
}