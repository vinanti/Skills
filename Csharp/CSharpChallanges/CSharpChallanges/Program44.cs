//Make a Circle with OOP
using System;

namespace CSharpChallanges
{
        //unquote and use run to test these cases
    public class Program44{
        public static void Main44(string[] args){
            var q = new Circle(4.44);
            Console.WriteLine(q.GetArea());
            Console.WriteLine(q.GetPerimeter());
        }
    }
    class Rectangle
    {
        public double SideA;
        public double SideB;
        public Rectangle(double sideA, double sideB){
            SideA = sideA;
            SideB = sideB;
        }
        public double GetArea(){
            return SideA * SideB;
        }
        public double GetPerimeter(){
            return (SideA + SideB) * 2;
        }
    }
    public class Circle {
        public double radius;
	    public Circle(double r){
            radius = r;
        }
        public double GetArea(){
            return Math.PI * radius * radius;
        }
        public double GetPerimeter(){
            return 2 * Math.PI * radius;
        }
    }
}