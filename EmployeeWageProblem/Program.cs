﻿namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the option");
                Console.WriteLine("1.Attendance \n2.Daily Employee Wage \n3.Part Time Employee Wage \n4.Switch Case Statement " +
                    "\n5.Monthly Wages \n6.Total Monthly Wages \n7.Refactor Employee Wage \n8.Employee Wage Multiple Companies " +
                    "\n9.Total Wage for Each Company \n10.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        employeeWage.Attendence();
                        break;
                    case 2:
                        employeeWage.EmpWage();
                        break;
                    case 3:
                        employeeWage.PartTime();
                        break;
                    case 4:
                        employeeWage.SwitchCase();
                        break;
                    case 5:
                        employeeWage.MonthlyWage();
                        break;
                    case 6:
                        employeeWage.TotalMonthlyWages();
                        break;
                    case 7:
                        employeeWage.RefactorEmployeeWageClass();
                        break;
                    case 8:
                        employeeWage.EmpWagesForMultipleCompany("Apple");
                        employeeWage.EmpWagesForMultipleCompany("Deloite");
                        break;
                    case 9:
                        EmpWageBuilder program = new EmpWageBuilder();
                        program.EmployeeWage("Infosys", 80, 12, 90);
                        program.ComputeWage();
                        EmpWageBuilder wipro = new EmpWageBuilder();
                        wipro.EmployeeWage("TCS", 55, 22, 110);
                        wipro.ComputeWage();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}