using System;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities;

//HERANÇA E POLIMORFISMO
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("O Funcionário é terceirizado? y/n");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome do funcionário: ");
                string name = Console.ReadLine();
                Console.WriteLine("Quantidade de horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o valor por hora trabalhado: ");
                double valuePerHours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else{

                    list.Add(new Employee(name, hours, valuePerHours));
        
                    }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS");
                foreach (Employee emp in list) 
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
                        
        }
        
    }
}