using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceDemo
{
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 1.0;
        }

        public Circle(double radius, string color, DateTime createdDate):base(color,createdDate)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Radius; {Radius}, Color: {Color}, Created Date: {CreatedDate}";
        }
    }
}
