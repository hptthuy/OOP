using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Time
    {
        int hour;
        int minute;
        int second;
        public int gethour { get { return hour; } }
        public int SetHour (int i) { return hour = i; } 
        int Minute { get; set; }
        int Second { get; set; }

        public Time() // hok có tham số thì khai báo ở trong ngoặc nhọn
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public Time(int h, int m, int s) // có tham số thì khai báo trong ngoặc tròn 
        {
            hour = h;
            minute = m;
            second = s;
        }
        public void Show()
        {
            Console.Write(" \n   " + hour + ":" + minute + ":" + second );


        }

    }
}

