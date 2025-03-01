using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes=new List<Shape>();

        Square s1=new Square("red", 1);
        shapes.Add(s1);

        Rectangle s2=new Rectangle("Blue", 2, 3);
        shapes.Add(s2);

        Circle s3=new Circle("Green", 6);
        shapes.Add(s2);        


        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area=s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }     
    }
}