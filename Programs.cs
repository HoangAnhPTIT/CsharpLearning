using ConsoleApp.Implements;
using ConsoleApp.Models;
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
            var flyWithWings = new FlyWithWings();
            var quack = new MuteQuack();
            var mallardDuck = new MallardDuck(flyWithWings, quack);

            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
        }
    }
}
