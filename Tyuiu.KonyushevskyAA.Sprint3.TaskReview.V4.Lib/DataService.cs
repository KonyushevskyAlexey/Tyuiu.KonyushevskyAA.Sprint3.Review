using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KonyushevskyAA.Sprint3.TaskReview.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArrey;
            int len = (stopValue - startValue) + 1;
            valueArrey = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2 * x + 6) / (Math.Cos(x) + x)) - 3, 2);
                valueArrey[count] = y;
                count++;
            }
            return valueArrey;
        }
    }
}
