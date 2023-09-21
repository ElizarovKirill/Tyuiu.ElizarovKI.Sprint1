using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElizarovKI.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            bool insideX1 = x1 < 1 || x1 > 8;
            bool insideY1 = y1 < 1 || y1 > 8;
            bool insideX2 = x2 < 1 || x2 > 8;
            bool insideY2 = y2 < 1 || y2 > 8;

            if (insideX1 || insideY1 || insideX2 || insideY2)
            {
                return false;
            }

            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);

            return x == y;
        }
    }
}
