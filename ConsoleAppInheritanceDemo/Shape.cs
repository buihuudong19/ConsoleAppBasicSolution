using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceDemo
{
   public class Shape
   {
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }

        public Shape()
        {
            Color = "Blue";
            CreatedDate = new DateTime(2024,05,30);
        
        }
        public Shape(string color, DateTime createdDate)
        {
            Color = color;
            CreatedDate = createdDate;
        }
    }
}
