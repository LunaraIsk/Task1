using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class PointPlane : Point
    {
        protected double x;
        protected double y;
        readonly string name = "point";
        public PointPlane(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string Name()
        {
            return name;

        }
        public override void Show()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
        public override double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 2)
            {
                this.x = ar[0];
                this.y = ar[1];
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
