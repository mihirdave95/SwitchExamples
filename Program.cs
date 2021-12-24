using System;
using SwitchExamples.Examples;
using SwitchExamples.Examples.Models;

namespace SwitchExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# 6 or before
            // TraditionalSwitch.Run("2");

            // C# 7
            // SwitchCSharp7Example.Run(1);
            // SwitchCSharp7Example.Run(1.05);
            // SwitchCSharp7Example.Run(new Person { Name = "Joe" });
            // SwitchCSharp7Example.Run("User");
            // SwitchCSharp7Example.Run(null);

            // C# 7 Case Guards
            // SwitchCSharp7CaseGuard.Run(0);
            // SwitchCSharp7CaseGuard.Run(1);
            // SwitchCSharp7CaseGuard.Run(.05);
            // SwitchCSharp7CaseGuard.Run(1.05);
            // SwitchCSharp7CaseGuard.Run(new Person { Name = "Joe" });
            // SwitchCSharp7CaseGuard.Run(new Person());
            // SwitchCSharp7CaseGuard.Run("User");
            // SwitchCSharp7CaseGuard.Run(null);

            // C# 8 Expressions
            // Console.WriteLine(SwitchCSharp8Expression.Run("2"));
            // Console.WriteLine(SwitchCSharp8Expression.RunSimplified("3"));
            // Console.WriteLine(SwitchCSharp8Expression.RunSimplified("55"));

            // C# 8 Property Patterns
            // Console.WriteLine(
            //     SwitchCSharp8PropertyPattern.Run(new Person { Name = "Joe", Age = 10 })
            // );
            // Console.WriteLine(SwitchCSharp8PropertyPattern.Run(
            //     new Person { Name = "John", Age = 40 })
            // );
            // Console.WriteLine(SwitchCSharp8PropertyPattern.Run(
            //     new Person { Name = "Tom", Age = 16 })
            // );

            // C# 9 relational pattern 
            Console.WriteLine(
                SwitchCSharp9RelationalPattern.GetAgeGroup(new Person { Name = "Joe", Age = 10 })
            );
            Console.WriteLine(
                SwitchCSharp9RelationalPattern.GetAgeGroup(new Person { Name = "John", Age = 45 })
            );
            Console.WriteLine(
                SwitchCSharp9RelationalPattern.GetAgeGroup(new Person { Name = "Sam", Age = 16 })
            );
            Console.WriteLine(
                SwitchCSharp9RelationalPattern.GetAgeGroup(new Person { Name = "Tony", Age = 30 })
            );
        }
    }
}
