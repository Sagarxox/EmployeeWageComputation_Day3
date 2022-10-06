using System;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        public static void EmployeeAttendence()
        {

            const int Is_Full_time = 1;
            const int Is_Part_time = 2;
            const int Emp_Rate_per_hour = 20;
            //Variables
            int Num_Of_Working_days = 20;
            int totalHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            for (int i = 0; i < Num_Of_Working_days; i++)
            {
                Random obj = new Random();
                int empCheck = obj.Next(3);

                //Computation
                switch (empCheck)
                {
                    case Is_Full_time:
                        empHrs = 8;
                        break;

                    case Is_Part_time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalHrs += empHrs;
            }
            

            Console.WriteLine("Total working hours: {0}", totalHrs);
            empWage = Emp_Rate_per_hour * totalHrs;
            Console.WriteLine("Total employee wage is: " + empWage);



        }
    }
}
