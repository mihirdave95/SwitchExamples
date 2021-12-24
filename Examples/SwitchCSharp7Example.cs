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
                case int localInput:
                    Console.WriteLine("integer input");
                    break;
                case double localInput:
                    Console.WriteLine("double input");
                    break;
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