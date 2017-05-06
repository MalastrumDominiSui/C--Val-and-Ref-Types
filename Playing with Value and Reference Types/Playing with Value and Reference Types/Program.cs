using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing_with_Value_and_Reference_Types
{
    class Program
    {
        public static void Main(string[] args)
        {
            JadenCase.ToJadenCase("A string");
        }

    }

    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            Console.WriteLine(phrase);
            Console.ReadKey();
            return null;
        }
    }
}
