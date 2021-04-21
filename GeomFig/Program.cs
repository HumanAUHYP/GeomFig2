using System;

class Program
{
    static void Main()
    {

    }

    public class Point
    {
        protected int Ax;
        protected int Ay;

        public Point(int newAx, int newAy)
        {
            Ax = newAx;
            Ay = newAy;
        }
        public virtual void Draw()
        { }
    }

    public class Line : Point
    {
        protected int Bx;
        protected int By;

        public Line(int newAx, int newAy, int newBx, int newBy) : base(newAx, newAy)
        {
            Bx = newBx;
            By = newBy;
        }

        public override void Draw()
        {
            Console.WriteLine($"A({Ax}; {Ay}), B({Bx}; {By})");
        }
    }

    public class Rectangle : Point
    {
        protected int Bx;
        protected int By;

        public Rectangle(int newAx, int newAy, int newBx, int newBy) : base(newAx, newAy)
        {
            Bx = newBx;
            By = newBy;
        }

        public override void Draw()
        {
            Console.WriteLine($"A({Ax}; {Ay}), B({Bx}; {By})");
        }
    }

    public class Triangle : Point
    {
        protected int Bx;
        protected int By;
        protected int Cx;
        protected int Cy;

        public Triangle(int Ax, int Ay, int Bx, int By, int Cx, int Cy) : base(Ax, Ay)
        {
            this.Bx = Bx;
            this.By = By;
            this.Cx = Cx;
            this.Cy = Cy;
        }

        public override void Draw()
        {
            Console.WriteLine($"A({Ax}; {Ay}), B({Bx}; {By}), C({Cx}; {Cy})");
        }
    }

    public class Circle : Point
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public override void Draw()
        {
            Console.WriteLine($"Radius: {r}, Center: ({Ax}, {Ay})");
        }
    }
}
