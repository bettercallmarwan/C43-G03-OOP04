using C43_G03_OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP04.Classes
{
    internal class Rectangle : IRectangle
    {
        public int length { get ; set; }
        public int width { get; set; }
        public double Area { get => length * width;}

        public void DisplayShapeInfo()
            => Console.WriteLine($"Rectangle : Length = {length}, Width = {width}, Area = {Area}");

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
    }
}
