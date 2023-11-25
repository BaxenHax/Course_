using Curso.Entities;
using Curso.Entities.Enums;
using System;

namespace Curso
{
    class program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }

        
    }
}