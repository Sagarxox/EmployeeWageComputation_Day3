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
            int emphrs = 0  ;
            

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case 1:
                    emphrs = 8;
                    Console.WriteLine("\n employee is full time");
                    break;

                case 2:
                    emphrs = 4;
                    Console.WriteLine("\n employee is part time");
                    break;
                default:
                    emphrs = 0;
                    Console.WriteLine("\n employee absent");
                    break;

            }
                    EmpWage = emphrs * EMP_RATE_PER_HOUR;

                    Console.WriteLine(" \n Employee wage : " + EmpWage);





            
        }
    }
}
