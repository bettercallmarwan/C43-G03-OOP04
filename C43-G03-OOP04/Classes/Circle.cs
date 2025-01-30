using C43_G03_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Classes
{
    internal class Circle : ICircle
    {
        public double radius { get; set; }
        public double Area { get => Math.PI * radius * radius;}

        public void DisplayShapeInfo() 
            => Console.WriteLine($"Circle : Radius = {radius} and Area = {Area}");

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
