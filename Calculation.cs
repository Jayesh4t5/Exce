using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exce
{
    public class Calculation
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        
        }

    }

    public static class Extentionm
    {
        public static int Multiply( this Calculation c, int a,int b)
        {
            return a * b;
        }

        public static int Square( this Calculation c,int a)
        {
            return a * a;
        }
    }
}
