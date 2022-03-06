using ConsoleApp.SupperType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Moew();
        }

        private void Moew()
        {
            Console.WriteLine("Moew moeww");
        }
    }
}
