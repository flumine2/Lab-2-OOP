using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Block
{
    static class Extensions
    {
        public static bool IsRectangle<T>(this T[][] arr)
        {
            if (arr.Length == 0) return false;

            int length = arr[0].Length;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length != length)
                    return false;
            }
            return true;
        }

        public static double ReturnLower(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
    }
}
