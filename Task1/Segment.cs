using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Segment : Point
    {
        internal PointSpace begin;
        internal PointSpace end;


        readonly string name = "segment";

        public Segment(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            begin = new PointSpace(x1, y1, z1);
            end = new PointSpace(x2, y2, z2);
        }
        public override string Name()
        {
            return name;
        }
        public override void Show()
        {
            Console.Write("Начало отрезка");
            begin.Show();
            Console.Write("Конец отрезка");
            end.Show();
        }
        public override double Distance()
        {
            return Math.Sqrt(Math.Pow(begin.X - end.X, 2) + Math.Pow(begin.Y - end.Y, 2) + Math.Pow(begin.Z - end.Z, 2));
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 6)
            {
                begin.Set(ar[0], ar[1], ar[2]);
                end.Set(ar[3], ar[4], ar[5]);
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public PointSpace Begin
        {
            get
            {
                return begin;
            }
            set
            {
                begin = value;
            }
        }
        public PointSpace End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
            }
        }
    }
}
