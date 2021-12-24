using SwitchExamples.Examples.Models;

namespace SwitchExamples.Examples
{
    public class SwitchCSharp9RelationalPattern
    {
        public static string GetAgeGroup(Person person) =>
        person switch
        {
            // relational pattern with property pattern
            { Age: <= 10 } => $"{person.Name}, You're just a kid.",
            // relational pattern with logical and property pattern 
            { Age: > 10 and <= 20 } => $"{person.Name}, You're just a bit older kid.",
            { Age: > 20 and <= 40 } => $"{person.Name}, You're now adult.😉",
            { Age: > 40 } => $"{person.Name}, You're still young.😎",
        };
    }
}