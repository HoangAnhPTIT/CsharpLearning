using ConsoleApp.Behaviors;
using ConsoleApp.Implements;
using ConsoleApp.SupperType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quack) : base(flyBehavior, quack)
        {
        }
    }
}
