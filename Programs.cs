using ConsoleApp.Geometry;
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
        static async Task Main(string[] args)
        {
            await Process.PointInsidePolygon();
        }
    }
}
