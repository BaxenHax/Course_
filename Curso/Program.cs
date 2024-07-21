using System;
using System.Collections.Generic;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstração construtores DateTime
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 05, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 05, 58, 275);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // Demo Now, UtcNow, Today
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            // Demo do parametro Parse da classe DateTime
            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("2000/08/15");
            DateTime d10 = DateTime.Parse("2000/08/15 13:05:58");


            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);


            //Demo ParseExact
            DateTime d11 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("2000-08-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            

            Console.WriteLine(d11);
            Console.WriteLine(d12);



        }
    }
}