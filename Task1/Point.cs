using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract public class Point
    {
        abstract public string Name(); //возвращает имя объекта
        abstract public void Show(); //выводит объект на экран
        abstract public double Distance();//рассчитывает длину
        abstract public void Set(params int[] ar);//устанавливает поля объекта

    }
}
