using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Programs
    {
        static void Main(string[] args)
        {
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
        }
    }
}
