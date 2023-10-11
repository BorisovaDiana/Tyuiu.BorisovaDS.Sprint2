using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorisovaDS.Sprint2.Task2.V19.Lib;

namespace Tyuiu.BorisovaDS.Sprint2.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
             
            if (res)
            {
                Console.WriteLine("Тщчка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Тщчка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
