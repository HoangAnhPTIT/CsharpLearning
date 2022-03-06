using ConsoleApp.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SupperType
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;
        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            _quackBehavior.Quackk();
        }
    }
}
