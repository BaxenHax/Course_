﻿using Curso.Entities.Enums;
using Curso.Entities;
using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace Curso
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level,baseSalary, dept);
            Console.WriteLine("How Many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
             }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM / YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " +worker.Departament.Name);
        }
    }
}