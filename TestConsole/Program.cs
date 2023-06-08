using System;
using VsExamples.CalcLib;

namespace VsExamples.TestConsole // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int x = 10;
            int y = x + 20;
            Console.WriteLine("x + y = {0}" , Calc.Sum(x,y) );
        }
    }
}