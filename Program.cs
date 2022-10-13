
using EmployeeWageProblem;

namespace EmplyeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeCheck emp = new EmployeeCheck();
            emp.CalculateEmpWage("Trends",10,13,50);
            emp.CalculateEmpWage("TCS", 23, 50, 180);
    
        }
    }

}