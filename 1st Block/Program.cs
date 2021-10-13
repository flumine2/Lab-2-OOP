using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr0 = new double[3, 4] { {4, 6.005 , 7.7 , 9}, { 3, 4, 5, 1 }, { 4, 6.25, 4.91, 76 } };
            MyMatrix myMatrix0 = new MyMatrix(arr0);
            Console.WriteLine(myMatrix0.ToString());

            MyMatrix copyMatrix = new MyMatrix(myMatrix0);
            Console.WriteLine(copyMatrix.ToString());

            double[][] arr1 = new double[3][];
            arr1[0] = new double[] { 4, 6.005, 7.7, 9 };
            arr1[1] = new double[] { 3, 4, 5, 1 };
            arr1[2] = new double[] { 4, 6.25, 4.91, 76 };
            MyMatrix myMatrix1 = new MyMatrix(arr1);
            Console.WriteLine(myMatrix1.ToString());

            MyMatrix myMatrix2 = new MyMatrix(myMatrix0.ToString());
            Console.WriteLine(myMatrix2.ToString());

            string[] strarr = new string[] { "4 6,005 7,7 9", "3 4 5 1" , "4 6,25 4,91 76" };
            MyMatrix myMatrix3 = new MyMatrix(strarr);
            Console.WriteLine(myMatrix3.ToString());

            Console.WriteLine("+ matrix:");
            Console.WriteLine((myMatrix0 + myMatrix1).ToString());

            Console.WriteLine("* matrix:");
            Console.WriteLine((myMatrix0 * myMatrix1).ToString());

            Console.WriteLine("Height:");
            Console.WriteLine(myMatrix0.Height);

            Console.WriteLine("Width:");
            Console.WriteLine(myMatrix0.Width);

            Console.WriteLine("Java-style Height:");
            Console.WriteLine(myMatrix0.getHeight());

            Console.WriteLine("Java-style Width:");
            Console.WriteLine(myMatrix0.getWidth());

            Console.WriteLine("Java-style Getter:");
            Console.WriteLine("\t" + "Enter index i and j:");
            int[] indx0 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(myMatrix0.Getter(indx0[0],indx0[1]));

            Console.WriteLine("Java-style Setter:");
            Console.WriteLine("\t" + "Enter index i and j and value:");
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            myMatrix0.Setter(info[0], info[1], info[2]);
            Console.WriteLine(myMatrix0.ToString());

            Console.WriteLine("Indexator:");
            Console.WriteLine("\t" + "Enter index i and j:");
            int[] indx1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(myMatrix0[indx1[0], indx1[1]]);

            Console.WriteLine(myMatrix0.GetTransponedCopy().ToString());

            myMatrix0.TransponeMe();
            Console.WriteLine(myMatrix0.ToString());
        }
    }
}
