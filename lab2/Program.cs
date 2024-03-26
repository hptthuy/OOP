using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void bai2_1()
            {
                Time t1 = new Time();
                Time t2 = new Time(3,2,7);
                t1.Show();
                t2.Show();
            }

        static void Main(string[] args)
        {
            bai2_1();
            Console.ReadKey();

        }
    }
}
