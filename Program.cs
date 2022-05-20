using System;

namespace AbstractApp
{

     abstract class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public abstract void Draw();
        
        public Shape(int w,int h)
        {
            this.Width=w;
            this.Height=h;
        }
        public virtual int CalculateArea()
        {
            return this.Width * this.Height;
        }

        
    }

    class Square : Shape
    {
        public Square(int w,int h) : base(w,h)
        {
            this.Width=w;
            this.Height=h;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw a Square. ");
        }
        
    }

    class Rectangular : Shape
    {
        public Rectangular(int w,int h) : base(w,h)
        {
            this.Width=w;
            this.Height=h;
        }
         public override void Draw()
        {
            Console.WriteLine("Draw a Rectangular. ");
        }
        

    }

    class Cube : Shape 
    {   
        public Cube(int w,int h, int sw) : base(w,h)
        {
            this.Width=w;
            this.Height=h;
            this.sideWidth=sw;
        }
        public int sideWidth { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Draw a Cube. ");
        }

        public override int CalculateArea()
        {
            return this.Width*this.Height*this.sideWidth;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           var shapes = new Shape [3];

           shapes[0] = new Square(10,12);
           shapes[1] = new Rectangular(11,23);
           shapes[2] = new Cube(10,10,10);

           foreach (var s in shapes)
           {
               s.Draw();
               Console.WriteLine($"Area : {s.CalculateArea()}");
           }
           
           
        }
    }
}
