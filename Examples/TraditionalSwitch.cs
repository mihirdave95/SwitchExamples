using System;

namespace SwitchExamples.Examples
{
    internal static class TraditionalSwitch
    {
        internal static void Run(string option)
        {
            Console.Write($"input - {option} Output - ");
            switch (option)
            {
                case "1":
                    Console.WriteLine("Using Option 1");
                    break;
                case "2":
                    Console.WriteLine("Using Option 2");
                    break;
                case "3":
                    Console.WriteLine("Using Option 2");
                    break;
                default:
                    Console.WriteLine("Unsupported option");
                    break;
            }
        }
    }
}