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
            int total_Working_Hrs = 100;
            int TotalWorkingDays = 0;
            int TotalEmpHrs = 0 ;
            int empHrs   ;
            int TotalEmpWage  ;
           
            


                for (int i = 0; i < Num_Of_Working_days; i++)
                {
                    while (TotalEmpHrs <= total_Working_Hrs && TotalWorkingDays < Num_Of_Working_days)
                    {
                        TotalWorkingDays++;
                        Random random = new Random();
                        int empCheck = random.Next(3);

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
                        Console.WriteLine("day {0} -> {1} hours worked .", TotalWorkingDays, TotalEmpHrs);
                        TotalEmpHrs = TotalEmpHrs + empHrs;

                    }
                }
            
            Console.WriteLine("Total working hours: {0}", TotalEmpHrs);
            Console.WriteLine("Total Worked Days : {0}", TotalWorkingDays);
            TotalEmpWage = Emp_Rate_per_hour * TotalEmpHrs;
            Console.WriteLine("Total employee wage is : {0} " ,TotalEmpWage);



        }
    }
}
