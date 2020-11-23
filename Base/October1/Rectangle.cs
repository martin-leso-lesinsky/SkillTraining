using System;

namespace SkillTraining.Base.October1
{
    class Rectangle
    {
        //member variables
        public double length;
        public double width;
        
        public double GetArea() {
            return length * width;
        }
        public void Display() 
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        public static void CreateRectangle()
        {
            Console.WriteLine("Hello World!");

            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}