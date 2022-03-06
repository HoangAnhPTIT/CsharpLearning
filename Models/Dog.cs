using ConsoleApp.SupperType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Bake();
        }

        private void Bake()
        {
            Console.WriteLine("Goh gohh");
        }
    }
}
