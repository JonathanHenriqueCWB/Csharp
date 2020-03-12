using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa older = new Pessoa();

            Console.WriteLine("Enter the name of the first person: ");
            p1.Name =Console.ReadLine();

            Console.WriteLine("Enter as the age: ");
            p1.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the name of the second person: ");
            p2.Name =Console.ReadLine();

            Console.WriteLine("Enter as the age: ");
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
            {
                older = p1;
            }
            else if(p1.Age < p2.Age)
            {
                older = p2;
            }

            if (p1.Age == p2.Age)
            {
                Console.WriteLine("Same age!!!");
            }
            else
            {
                Console.WriteLine("Older person: " + older.Name + " Age: " + older.Age); ;
            }         
        }
    }
}
