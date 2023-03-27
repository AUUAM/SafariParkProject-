using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp.Extra
{
    //Abstract classes cannot be instantiated
    //They can also contain concrete methods AND abstract methods
    public abstract class Shape
    {
        //Concrete method
        public override string ToString()
        {
            return $"This shape is {base.GetType()}";
        }

        //Abstract method - It has no method body therefore it must be implemented in derived classes
        public abstract double CalculateArea();     
    }

    //If I am inherting from a class with abstract methods
    //That abstract method must be implemented
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //override virtual AND abstract methods
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Triangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //override virtual AND abstract methods
        public override double CalculateArea()
        {
            return Width * Height * 0.5;
        }
    }
}
