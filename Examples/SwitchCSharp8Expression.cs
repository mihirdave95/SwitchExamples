namespace SwitchExamples.Examples
{
    public class SwitchCSharp8Expression
    {
        public static string Run(string option) =>
        option switch
        {
            // Constant Pattern
            // because we're using constant as matching expression
            "1" => "Using Option 1",
            "2" => "Using Option 2",
            "3" => "Using Option 3",
            // Discard Pattern
            _ => "Unsupported option",
        };

        public static string RunSimplified(string option)
        {
            // using an old school approach to show another use case
            var result = option switch
            {
                "1" => "Using Option 1",
                "2" => "Using Option 2",
                "3" => "Using Option 3",
                _ => "Unsupported option",
            };

            return result;
        }
    }
}