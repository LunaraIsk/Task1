using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class PointSpace : PointPlane //Производный класс - точка в пространстве
    {
        protected double z;
        public PointSpace(double x, double y, double z)
        : base(x, y)
        {
            this.z = z;
        }
        public override void Show()
        {
            Console.WriteLine("({0}, {1}, {2})", x, y, z);
        }
        public override double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public override void Set(params int[] ar)
        {
            if (ar.Length == 3)
            {
                this.x = ar[0];
                this.y = ar[1];
                this.z = ar[2];
            }
            else
            {
                Console.WriteLine("Неверное количество аргументов");
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
    }
}
