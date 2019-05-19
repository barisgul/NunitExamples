using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestExamples.CalculatorTests
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }

            string[] delimiters = { ",", "\n" };

            if (numbers.StartsWith("//"))
            {
                int endOfDeliminter = numbers.IndexOf("\n");
                delimiters = new string[] { numbers.Substring(2, endOfDeliminter - 2) };
                numbers = numbers.Substring(endOfDeliminter + 1);
            }

            int total = numbers
                            .Split(delimiters, StringSplitOptions.None)
                            .Select(x => int.Parse(x))
                            .Sum();

            return total;
        }
    }
}
