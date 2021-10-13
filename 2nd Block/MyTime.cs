using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Block
{
    class MyTime
    {
        private int h, m, s;
        public MyTime(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }

        public override string ToString()
        {
            Normalise();
            return h + ":" + m.ToString("D2") + ":" + s.ToString("D2");
        }

        public int TimeSinceMidnight()
        {
            Normalise();
            return h * 3600 + m * 60 + s;
        }

        public MyTime TimeSinceMidnight(int t)
        {
            Normalise();
            int h = (int) Math.Floor(t / 3600.0);
            int m = (int)Math.Floor(t % 3600 / 60.0);
            int s = t % 3600 % 60;
            return new MyTime(h, m, s);
        }

        public int AddOneSecond() => s++;

        public int AddOneMinute() => m++;

        public int AddOneHour() => h++;

        public int AddSeconds(int s) => this.s += s;

        public static int Difference(MyTime mt1, MyTime mt2) => mt1.TimeSinceMidnight() - mt2.TimeSinceMidnight();

        public string WhatLesson()
        {
            Normalise();
            int time = TimeSinceMidnight();
            if (time < 8 * 3600)
                return "Пари не розпочалися";

            else if (time >= 8 * 3600 && time < 9 * 3600 + 20 * 60)
                return "1 пара";

            else if (time >= 9 * 3600 + 20 * 60 && time < 9 * 3600 + 40 * 60)
                return "Перерва між 1-ою і 2-ою парою";

            else if (time >= 9 * 3600 + 40 * 60 && time < 11 * 3600)
                return "2 пара";

            else if (time >= 11 * 3600 && time < 11 * 3600 + 20 * 60)
                return "Перерва між 2-ою і 3-ою парою";

            else if (time >= 11 * 3600 + 20 * 60 && time < 12 * 3600 + 40 * 60)
                return "3 пара";

            else if (time >= 12 * 3600 + 40 * 60 && time < 13 * 3600)
                return "Перерва між 3-ою і 4-ою парою";

            else if (time >= 13 * 3600 && time < 14 * 3600 + 20 * 60)
                return "4 пара";

            else if (time >= 14 * 3600 + 20 * 60 && time < 14 * 3600 + 40 * 60)
                return "Перерва між 4-ою і 5-ою парою";

            else if (time >= 14 * 3600 + 40 * 60 && time < 16 * 3600)
                return "5 пара";

            else if (time >= 16 * 3600 && time < 16 * 3600 + 20 * 60)
                return "Перерва між 5-ою і 6-ою парою";

            else if (time >= 16 * 3600 + 20 * 60 && time < 17 * 3600 + 40 * 60)
                return "6 пара";

            else if (time >= 17 * 3600 + 40 * 60)
                return "Пари Скінчились";

            return time.ToString();
        }

        public void Normalise()
        {
            if (s >= 60 || s < 0)
            {
                int temp = (int)Math.Floor((decimal)s / 60);
                s -= 60 * temp;
                m += temp;
            }
            if (m >= 60 || m < 0)
            {
                int temp = (int)Math.Floor((decimal)m / 60);
                m -= 60 * temp;
                h += temp;
            }
            if (h >= 24 || h < 0)
            {
                int temp = (int)Math.Floor((decimal)h / 24);
                h -= 24 * temp;
            }
        }
    }
}
