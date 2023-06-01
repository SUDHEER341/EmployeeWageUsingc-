using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        public const byte FULL_TIME = 1;
        public const byte PART_TIME = 2;
        public const byte PART_WORKING_HOURS = 4;
        public const byte FULL_WORKING_HOURS = 8;
        public const int WAGE_PER_HOUR = 20;
        public const byte WORKING_DAYS_PER_MONTH = 20;

        public int CheckAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);

            if (attendance == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                return FULL_TIME;
            }

            else if (attendance == PART_TIME)
            {
                Console.WriteLine("Employee is parttime present");
                return PART_TIME;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                return 0;
            }
        }

        public int Daily_Wage()
        {
            int employeeHours;
            int employeeCheck = CheckAttendance();

            if (employeeCheck == FULL_TIME)
            {
                employeeHours = FULL_WORKING_HOURS;
            }
            else if (employeeCheck == PART_TIME)
            {
                employeeHours = PART_WORKING_HOURS;
            }
            else
            {
                employeeHours = 0;
            }

            int dailyWage = employeeHours * WAGE_PER_HOUR;
            Console.WriteLine($"Employee Daily Wage is :  {dailyWage}");
            return dailyWage;
        }

        public void PartTimeEmployee()
        {
            int employeeCheck = Daily_Wage();
        }

        public int EmployeeUsingSwitchCase()
        {
            int employeeHours;
            int employeeCheck = CheckAttendance();

            switch (employeeCheck)
            {
                case 1:
                    employeeHours = FULL_WORKING_HOURS;
                    Console.WriteLine("Employee is a FullTime worker ");
                    break;
                case 2:
                    employeeHours = PART_WORKING_HOURS;
                    Console.WriteLine("Employee is a PartTime worker");
                    break;
                default:
                    employeeHours = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            int employeeWage = employeeHours * WAGE_PER_HOUR;
            Console.WriteLine($"Employee Daily Wage  is : {employeeWage}");
            return employeeWage;
        }

        public int MonthlyWage()
        {
            int monthlyWage = 0;
            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)

            {
                int dailWage = Daily_Wage();
                monthlyWage = dailWage;
            }
            Console.WriteLine($"Employee monthly wage is : {monthlyWage} ");
            return monthlyWage;
        }

        public void EmployeeUntillConditionReached()
        {
            int totalHours = 0;
            int totalWokingDays = 0;
            int max_HoursInMonth = 100;
            int employeeHours;
            int numberOfWorkingDays = 20;

            while (totalHours <= max_HoursInMonth && totalWokingDays < numberOfWorkingDays)
            {
                totalWokingDays++;
                Random random = new Random();
                int employeeCheck = random.Next(0, 3);
                switch (employeeCheck)
                {
                    case 1:
                        employeeHours = FULL_WORKING_HOURS;
                        Console.WriteLine("Employee is full time worker");
                        break;
                    case 2:
                        employeeHours = PART_WORKING_HOURS;
                        Console.WriteLine("Employee is part time worker");
                        break;
                    default:
                        employeeHours = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalHours += employeeHours;
                Console.WriteLine($"Day : {totalWokingDays} EmployeeHours : {employeeHours}");
            }
            int totalEmployeeWage = totalHours * WAGE_PER_HOUR;
            Console.WriteLine($" Total Employee wage is :- {totalEmployeeWage}");
        }
    }
}
