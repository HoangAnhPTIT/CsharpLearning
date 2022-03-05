using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MultiThreading
    {
        //static void Main(string[] args)
        //{
        //    DemoThread();
        //    DemoThread();
        //    DemoThread();
        //}

        public static void DemoThread()
        {
            for(int i = 0; i < 3; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(i);
            }
        }
    }

}
