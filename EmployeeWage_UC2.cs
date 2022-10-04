using System;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public static void EmployeeAttendence()
        { 


            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int EmpWage;
            int emphrs = 0;
            int empcheck = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is full time");
                emphrs = 8;

            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("employee is part time ");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("employee absent");
                emphrs = 0;
            }

            EmpWage = emphrs * EMP_RATE_PER_HOUR;

            Console.WriteLine(" Employee wage : " +EmpWage);






        }
    }
}
