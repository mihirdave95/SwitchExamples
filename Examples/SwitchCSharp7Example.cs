using System;
using SwitchExamples.Examples.Models;

namespace SwitchExamples.Examples
{
    internal static class SwitchCSharp7Example
    {
        internal static void Run(object input)
        {
            Console.Write($"input - {input} Output - ");
            switch (input)
            {
                // this checks if localInput is of type int
                case int localInput:
                    Console.WriteLine("integer input");
                    break;
                // this checks if localInput is of type double
                case double localInput:
                    Console.WriteLine("double input");
                    break;
                // Notice the use of type with case
                case Person localInput:
                    Console.WriteLine("Person input");
                    break;
                default:
                    Console.WriteLine("UnKnown input");
                    break;
            }
        }
    }

}