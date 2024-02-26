using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities.Enums;
namespace Curso.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        { this.color = color; }
        public abstract double Area();


    }
}
