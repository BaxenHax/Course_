﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities.Enums;

namespace Curso.Entities
{
    internal class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color) : base(color)
        {

        }

        public Rectangle(double widht, double height,Color color) : base(color)
        {
            Widht = widht;
            Height = height;
        }

        public override double Area()
        {
            return Widht * Height;
        }
    }
}
