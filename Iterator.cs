﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Iterator
    {
        public static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for(int i = 0; i < 10; i++)
            {
                yield return i;
            }
            yield return 20;
        }
    }
}
