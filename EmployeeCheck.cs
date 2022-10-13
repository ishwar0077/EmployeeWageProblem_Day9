using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{

    public class EmployeeCheck
    {
        const int Is_Full_time = 1;
        const int Is_Part_time = 2;
        public void CalculateEmpWage(string company, int Emp_Rate_per_hour,int Num_Of_Working_days, int toatal_Wroking_Hrs)
        {
            //Variables
            int totalWorkingDays = 0;
            int totalHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            while (totalHrs < toatal_Wroking_Hrs && totalWorkingDays < Num_Of_Working_days)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(3);

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
            Console.WriteLine("total working hours: {0}, total worked days: {1}", totalHrs, totalWorkingDays);
            empWage = Emp_Rate_per_hour * totalHrs;
            Console.WriteLine("total employee wage for company {0} is: {1} ", company, empWage);

        }
    }
}
