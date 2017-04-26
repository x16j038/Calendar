using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            Console.Write("{0}年 {1}月\n", dateNow.Year, dateNow.Month);
            //Console.ReadLine();
        }
    }
}
