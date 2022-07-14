using System;

namespace Task1
{
    class Program
    {
        // Проверка правильности данных
        static bool GetFlag(double ab, double bc, double ac)
        {
            bool flag = false;
            if (ab >= bc + ac) flag = true;
            if (ac >= bc + ab) flag = true;
            if (bc >= ac + ab) flag = true;
            return flag;
        }

        // Расчет площади треугольника
        static double GetAreaTriangle(double ab, double bc, double ac)
        {
            double halfPerimetr = (ab + bc + ac) / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - ab) * (halfPerimetr - bc) * (halfPerimetr - ac));
        }

        static void Main(string[] args)
        {
            //ввод данных
            Console.WriteLine("Введите длины сторон первого треугольника");
            double sideTriangleAB1 = Convert.ToDouble(Console.ReadLine());
            double sideTriangleBC1 = Convert.ToDouble(Console.ReadLine());
            double sideTriangleAC1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника");
            double sideTriangleAB2 = Convert.ToDouble(Console.ReadLine());
            double sideTriangleBC2 = Convert.ToDouble(Console.ReadLine());
            double sideTriangleAC2 = Convert.ToDouble(Console.ReadLine());
            //проверка на корректность введенных данных
            bool flag1 = GetFlag(sideTriangleAB1, sideTriangleBC1, sideTriangleAC1);
            bool flag2 = GetFlag(sideTriangleAB2, sideTriangleBC2, sideTriangleAC2);
            if (flag1 || flag2)
            {
                Console.WriteLine("Неправильно введенные данные");
            }
            else
            {
                double areaTriangle1 = GetAreaTriangle(sideTriangleAC1, sideTriangleBC1, sideTriangleAB1);
                double areaTriangle2 = GetAreaTriangle(sideTriangleAC2, sideTriangleBC2, sideTriangleAB2);
                Console.WriteLine("Площадь треугольника 1 равна {0:.00}", areaTriangle1);
                Console.WriteLine("Площадь треугольника 2 равна {0:.00}", areaTriangle2);
                if (areaTriangle1 > areaTriangle2)
                    Console.WriteLine("Площадь треугольника 1 больше площади треугольника 2");
                else if (areaTriangle1 < areaTriangle2)
                    Console.WriteLine("Площадь треугольника 2 больше площади треугольника 1");
                else Console.WriteLine("Площади треугольников равны");
            }
            Console.ReadLine();
        }
    }
}
