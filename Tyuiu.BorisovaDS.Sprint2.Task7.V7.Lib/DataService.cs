using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BorisovaDS.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= (2 - x * x)) && (y >= x) && (x <= 0))
            {
                res = true;
            }
            if ((y <= (2 - x * x)) && (y > 0) && (x <= Math.Sqrt(2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
