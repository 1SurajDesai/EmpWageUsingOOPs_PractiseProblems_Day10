using System;
namespace EmployeeWageProblemWithObject
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program ");
            //EmployeeCheck empcheck = new EmployeeCheck();
            //empcheck.EmployeeAbsentOrPresent();
            //EmpyeeWage empwage = new EmpyeeWage();
            //empwage.CalculateEmpWage();
            //PartTimeWage partTimeWage = new PartTimeWage();
            //partTimeWage.CalEmpWage();
            //EmpWageUsingSwitchCase empWageUsingSwitchCase = new EmpWageUsingSwitchCase();
            //empWageUsingSwitchCase.CalWageSwitchCase();
            //WageForMonth wageForMonth = new WageForMonth();
            //wageForMonth.CalWageOfMonth();
            CalWageTillCondMeet calWageTillCondMeet = new CalWageTillCondMeet();
            calWageTillCondMeet.CalWage();

        }
    }
}