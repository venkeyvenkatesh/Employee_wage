using System;

namespace Employee_wage
{
    class Program
    {
        static void Main(string[] args)
        {
          
           Console.WriteLine("Hello welcome to Employee wage problem");
            
           
            
          
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            Console.WriteLine("Iam in usecase1 branch");
        }
    }
}
