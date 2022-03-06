using ConsoleApp.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Implements
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quackk()
        {
            Console.WriteLine("Mute Quackkkk");
        }
    }
}
