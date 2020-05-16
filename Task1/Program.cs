using System;
using System.IO;
namespace Task1
{
    class Program
    {
        static public Point[] Input() //читаем данные из файла
        {
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                int n = int.Parse(fileIn.ReadLine());
                Point[] ar = new Point[n];
                for (int i = 0; i < n; i++)
                {
                    string[] text = fileIn.ReadLine().Split(' ');
                    if (text.Length == 2)
                    {
                        ar[i] = new PointPlane(double.Parse(text[0]), double.Parse(text[1]));
                    }
                    else
                    {
                        if (text.Length == 3)
                        {
                            ar[i] = new PointSpace(double.Parse(text[0]), double.Parse(text[1]), double.Parse(text[2]));
                        }

                        else
                        {
                            if (text.Length == 6)
                            {
                                ar[i] = new Segment(double.Parse(text[0]), double.Parse(text[1]), double.Parse(text[2]),
                                double.Parse(text[3]), double.Parse(text[4]), double.Parse(text[5]));
                            }
                            else
                            {
                                ar[i] = new Pyramid(double.Parse(text[0]), double.Parse(text[1]), double.Parse(text[2]),
                                    double.Parse(text[3]), double.Parse(text[4]), double.Parse(text[5]), double.Parse(text[6]),
                                    double.Parse(text[7]), double.Parse(text[8]), double.Parse(text[9]), double.Parse(text[10]),
                                    double.Parse(text[11]), double.Parse(text[12]), double.Parse(text[13]), double.Parse(text[14]));
                            }
                        }
                    }
                }
                return ar;
            }
        }
        static void Print(Point[] array) //выводим данные на экран
        {
            using (StreamWriter fileout = new StreamWriter("output.txt"))
            {
                foreach (Pyramid temp in array)
                {
                    temp.Show();
                    fileout.WriteLine("Площадь основания правильной четырехугольной пирамиды: {0:f2}", temp.Square_osn());
                    fileout.WriteLine("Объем правильной четырехугольной пирамиды: {0:f2}", temp.V());
                   
                }
            }

        }
        static void Main(string[] args)
        {
            Point[] array = Input();
            Print(array);
            Console.ReadKey();
        }
    }
}
