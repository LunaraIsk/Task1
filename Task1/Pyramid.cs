using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Pyramid : Point
    {
        internal Segment sideAB;
        internal Segment sideAD;
        internal Segment sideAS;
        internal Segment sideBC;
        internal Segment sideBS;
        internal Segment sideCD;
        internal Segment sideCS;
        internal Segment sideDS;
        readonly string name = "pyramid";
        public Pyramid(double x1, double y1, double z1,
            double x2, double y2, double z2, double x3,
            double y3, double z3, double x4, double y4,
            double z4, double x5, double y5, double z5)
        {
            sideAB = new Segment(x1, y1, z1, x2, y2, z2);
            sideAD = new Segment(x1, y1, z1, x4, y4, z4);
            sideAS = new Segment(x1, y1, z1, x5, y5, z5);
            sideBC = new Segment(x2, y2, z2, x3, y3, z3);
            sideBS = new Segment(x2, y2, z2, x5, y5, z5);
            sideCD = new Segment(x3, y3, z3, x4, y4, z4);
            sideCS = new Segment(x3, y3, z3, x5, y5, z5);
            sideDS = new Segment(x4, y4, z4, x5, y5, z5);
        }
        public override string Name()
        {
            return name;
        }
        public override void Show()
        {
            Console.Write("Вершина A");
            sideAB.Begin.Show();
            Console.Write("Вершина B");
            sideBC.Begin.Show();
            Console.Write("Вершина C");
            sideCD.Begin.Show();
            Console.Write("Вершина D");
            sideDS.Begin.Show();
            Console.Write("Вершина S");
            sideDS.End.Show();
        }
        public override double Distance()
        {
            Console.WriteLine("Периметр основания: ");
            return sideAB.Distance() + sideBC.Distance() + sideCD.Distance() + sideAD.Distance();
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 15)
            {
                sideAB.Set(ar[0], ar[1], ar[2], ar[3], ar[4], ar[5]);
                sideBC.Set(ar[3], ar[4], ar[5], ar[6], ar[7], ar[8]);
                sideCD.Set(ar[6], ar[7], ar[8], ar[9], ar[10], ar[11]);
                sideAD.Set(ar[0], ar[1], ar[2], ar[9], ar[10], ar[11]);
                sideAS.Set(ar[0], ar[1], ar[2], ar[12], ar[13], ar[14]);
                sideBS.Set(ar[3], ar[4], ar[5], ar[12], ar[13], ar[14]);
                sideCS.Set(ar[6], ar[7], ar[8], ar[12], ar[13], ar[14]);
                sideDS.Set(ar[9], ar[10], ar[11], ar[12], ar[13], ar[14]);
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public double Square_osn()//Метод, позволяющий расчитать площадь основания
        {
            double S_osn = sideAB.Distance() * sideBC.Distance();
            return S_osn;
        }

        public double V()//Метод, позволяющий расчитать объём пирамиды
        {
            double sideAC = Math.Sqrt(sideAD.Distance() * sideAD.Distance() + sideCD.Distance() * sideCD.Distance());
            double sideAH = sideAC / 2;
            double sideSH = Math.Sqrt(sideAS.Distance() * sideAS.Distance() - sideAH * sideAH);
            double V = Square_osn() * sideSH / 3;
            return V;
        }
    }
}
