using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Block
{
    class MyMatrix
    {
        double[,] data;

        public MyMatrix(MyMatrix myMatrix)
        {
            data = myMatrix.data;
        }

        public MyMatrix(double[,] arr)
        {
            data = arr;
        }

        public MyMatrix(double[][] arr)
        {
            if (!arr.IsRectangle()) throw new NotImplementedException("Matrix must have height and Width.");

            double[,] res = new double[arr.Length, arr[0].Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    res[i, j] = arr[i][j];
                }
            }
            data = res;
        }

        public MyMatrix(string[] arr)
        {
            double[,] vs = new double[arr.Length, arr[0].Split(new char[] { ' ' }).Length];
            for (int i = 0; i < arr.Length; i++)
            {
                double[] nums = arr[i].Split(new char[] { ' ' }).Select(double.Parse).ToArray();
                for (int j = 0; j < nums.Length; j++)
                {
                    vs[i, j] = nums[j];
                }
            }
            data = vs;
        }

        public MyMatrix(string str)
        {
            
            string[] array = str.Split(new char[] { '\n'}).ToArray();
            double[,] vs = new double[array.Length, array[0].Split(new char[] { ' ', '\t' }).Length];
            for (int i = 0; i < array.Length; i++)
            {
                double[] arr = array[i].Split(new char[] { ' ', '\t' }).Select(double.Parse).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    vs[i, j] = arr[j];
                }
            }
            data = vs;
        }

        public static MyMatrix operator +(MyMatrix a, MyMatrix b)
        {
            if (IsEqualSize(a, b))
            {
                double[,] vs = new double[a.data.GetLength(0), a.data.GetLength(1)];
                for (int i = 0; i < vs.GetLength(0); i++)
                {
                    for (int j = 0; j < vs.GetLength(1); j++)
                    {
                        vs[i, j] = a.data[i, j] + b.data[i, j];
                    }
                }
                MyMatrix myMatrix = new MyMatrix(vs);
                return myMatrix;
            }
            else
                throw new NotImplementedException();
        }

        public static MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            int curr1 = (int)Extensions.ReturnLower(a.data.GetLength(0), a.data.GetLength(1));
            int curr2 = (int)Extensions.ReturnLower(b.data.GetLength(0), b.data.GetLength(1));

            double[,] vs = new double[curr1, curr2];
            for (int i = 0; i < vs.GetLength(0); i++)
            {
                for (int j = 0; j < vs.GetLength(1); j++)
                {
                    double sum = 0;
                    for (int q = 0; q < a.data.GetLength(0); q++)
                    {
                        sum += a.data[j, q] * b.data[q, j];
                    }
                    vs[i, j] = sum;
                }
            }
            MyMatrix myMatrix = new MyMatrix(vs);
            return myMatrix;
        }

        public int Height { get => data.GetLength(0); }

        public int getHeight() => data.GetLength(0);

        public int Width { get => data.GetLength(1); }

        public int getWidth() => data.GetLength(1);

        public double Getter(int i, int j)
        {
            return data[i, j];
        }

        public void Setter(int i, int j, double value)
        {
            data[i, j] = value; 
        }

        public double this[int i, int j]
        {
            get => data[i, j];
            set
            {
                data[i, j] = value;
            }
        }

        override public String ToString()
        {
            string rtn = "";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    rtn += data[i, j];
                    if (j < data.GetLength(1) - 1)
                    {
                        rtn += "\t";
                    }
                }
                if (i < data.GetLength(0) - 1)
                {
                    rtn += "\n";
                }
            }    
            return rtn;
        }

        private double[,] GetTransponedArray()
        {
            double[,] arr = new double[data.GetLength(1), data.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = data[j, i];
                }
            }
            return arr;
        }

        public MyMatrix GetTransponedCopy() => new MyMatrix(GetTransponedArray());

        public void TransponeMe()
        {
            data = GetTransponedArray();
        }

        public static bool IsEqualSize(MyMatrix a, MyMatrix b)
        {
            if (a.data.Length == b.data.Length)
            {
                if (a.data.GetLength(0) == b.data.GetLength(0))
                {
                    if (a.data.GetLength(1) == b.data.GetLength(1))
                    {
                        return true;
                    }
                    else 
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

    }
}
