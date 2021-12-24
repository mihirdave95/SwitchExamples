using System;
using SwitchExamples.Examples.Models;

namespace SwitchExamples.Examples
{
    internal static class SwitchCSharp7CaseGuard
    {
        internal static void Run(object input)
        {
            Console.Write($"input - {input} Output - ");
            switch (input)
            {
                case int localInput when localInput > 0:
                    Console.WriteLine("integer input");
                    break;
                case double localInput when localInput > 0.5:
                    Console.WriteLine("double input");
                    break;
                case Person localInput when !string.IsNullOrWhiteSpace(localInput.Name):
                    Console.WriteLine("Person input");
                    break;
                default:
                    Console.WriteLine("UnKnown input");
                    break;
            }
        }
    }
}