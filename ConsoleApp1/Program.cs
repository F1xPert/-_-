using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__1
{
    class Rectangle
    {
        public int hight;
        public int width;

        public int Perimetr()
        {
            return 2 * hight + 2 * width;
        }
        public void Show()
        {
            Console.WriteLine("Прямоугольник: \nвысота = " + hight + "\nширина = " + width);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle side = new Rectangle();
            side.hight = 2;
            side.width = 3;
            side.Show();
            int P = side.Perimetr();
            Console.WriteLine("Периметр = " + P);
            Console.ReadKey();
        }
    }
}

