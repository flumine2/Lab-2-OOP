using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTime myTime = new MyTime(22,58,59);
            Console.WriteLine(myTime.TimeSinceMidnight());
            Console.WriteLine(myTime.TimeSinceMidnight(15261).ToString()) ;
            myTime.AddOneSecond();
            Console.WriteLine(myTime.ToString());
            myTime.AddOneMinute();
            Console.WriteLine(myTime.ToString());
            myTime.AddOneHour();
            Console.WriteLine(myTime.ToString());
            myTime.AddSeconds(-25);
            Console.WriteLine(myTime.ToString());

            MyTime myTime1 = new MyTime(12, 30, 30);
            Console.WriteLine(MyTime.Difference(myTime, myTime1));
            Console.WriteLine(myTime1.WhatLesson());
            Console.WriteLine(myTime.WhatLesson());
        }
    }
}
