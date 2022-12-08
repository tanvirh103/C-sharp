using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class Shape {
       private double length;
        public double Length {
            get { return length; }
            set { length = value; }
        }
    }
    class Rectangle :Shape{
       private double width;
        public double Width {
            get { return width; }
            set { width = value; }
        }
        public void getArea() {
            Console.WriteLine("Area of Rectangle: "+Length*Width);
        }
    }
    class Triangle:Shape {
       private float height;
        public float Height
        {
            get { return height; }
            set { height = value; } 
        }
    }
    class Square:Shape {
        public void getArea() {
            Console.WriteLine("Area from Square: "+Length*Length);
        }
       
    }
    class Box : Rectangle {
        private double height;
        public double Height
        {
             get { return height; }
            set { height = value; }
        }
        public void getVolume() { 
        Console.WriteLine("Volume from Box: "+Length*Height*Width);
        }
    }
        
    
    internal class Program

    {   //Inheritance//
        //tryparse//
        //Multiple Inheritance//

        /*public void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }*/
        static void Main(string[] args)
        {
            Square s1 = new Square();
            s1.Length = 20;
            s1.getArea();
            Rectangle r1 = new Rectangle();
            r1.Length = 5;
            r1.Width = 6;
            r1.getArea();
            Box b1 = new Box();
            b1.Length = 5;
            b1.Height = 6;
            b1.Width = 5;
            b1.getVolume();
           
            
            /*Program p=new Program();
           
            int x;
            int y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(),out y);
            p.swap(ref x,ref y);
            Console.WriteLine("X="+x);
            Console.WriteLine("y="+y);*/
            
        }
    }
}
