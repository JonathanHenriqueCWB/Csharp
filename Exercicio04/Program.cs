using Exercicio04.Model;
using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0;
            Employee employee = new Employee();

            Console.WriteLine("Enter name of the Employee: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter Salary of the Employee: ");
            employee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter of the tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(employee.NetSalary());

            Console.WriteLine("Enter a new percentage rate: ");
            tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(employee.IncreasesSalary(tax));
        }
    }
}
