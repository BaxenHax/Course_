using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutSourcedEmployee() 
        { 
        
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHours, double additionalcharge) 
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalcharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


    }
}
