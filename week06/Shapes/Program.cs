using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shape=new List<Shape>();

        shape.add(new Square());
        shape.add(new Rectangle());
        shape.add(new Circle());   

        foreach(Shape shape in shape)
        {
            string color = shape.GetColor();
            Console.WriteLine(color);
            
            float double area=shape.GetArea();
            Console.WriteLine(area);
        }     
    }
}