using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Cube
{
    class Program
    {

        static void  GetAreaVolumeCube (double b, out double a, out double s )
        {
            s = b * b * b; // вычисление объема куба
            a = 6 * b * b; // вычисление площади граней куба
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину грани куба");
            double edgeCube = Convert.ToDouble(Console.ReadLine());
            double area, volume;
            GetAreaVolumeCube(edgeCube, out area, out volume);
            Console.WriteLine("Площадь граней куба составляет {0}, объем куба - {1}", area, volume);
            Console.ReadKey();
        }
    }
}
