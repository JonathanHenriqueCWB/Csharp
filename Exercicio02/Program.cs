using System;
using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            
            Console.WriteLine("Enter the name of the employee");
            e1.Name= Console.ReadLine();

            Console.WriteLine("Enter the salary of the employee");
            e1.Salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the name of the employee");
            e2.Name = Console.ReadLine();

            Console.WriteLine("Enter the salary of the employee");
            e2.Salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal average = CalculateAverage(e1.Salary, e2.Salary);
            Console.WriteLine("The average salary is: " + average);

        }

        public static decimal CalculateAverage(decimal n1, decimal n2)
        {
            return (n1 + n2) / 2;
        }
    }
}
