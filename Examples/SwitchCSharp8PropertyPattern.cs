using SwitchExamples.Examples.Models;

namespace SwitchExamples.Examples
{
    public class SwitchCSharp8PropertyPattern
    {
        public static string Run(Person person) =>
        person switch
        {
            // this expression will only matched when person's Name is Joe and Age is 10
            { Name: "Joe", Age: 10 } => "Hello Joe",
            // this expression will only matched when person's Name is John
            { Name: "John" } => "Hello John",
            // Discard Pattern
            _ => "Sorry But we don't know you.",
        };
    }
}