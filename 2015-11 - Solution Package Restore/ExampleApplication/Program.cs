using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Nuget version: " + NuGet.Constants.NuGetVersion);
            Console.ReadLine();
        }
    }
}
