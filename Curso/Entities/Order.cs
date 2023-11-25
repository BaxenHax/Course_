using Curso.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities.Enums;

namespace Curso.Entities
{
    internal class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status  { get; set; }

        public override string ToString()
        {
            return ID + ", "  +Moment + "," +Status;
        }

    }
}
