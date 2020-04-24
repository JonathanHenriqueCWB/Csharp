using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Tax { get; set; }

        public double NetSalary()
        {
            return Salary - Tax;
        }

        public double IncreasesSalary(double tax)
        {
            double percentual = tax / 100.0;
            double valor_final = Salary + (percentual * Salary);
            return valor_final;
        }
    }
}
