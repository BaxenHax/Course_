﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities.Enums;
using Curso.Entities;


     class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) :base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

