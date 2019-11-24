using System;
using System.Text;

namespace Project_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    string output = String.Format("{0} {1}",
                               i, " FizzBuzz");
                    sb.AppendLine(output);
                }
                else if (i % 5 == 0)
                {
                    string output = String.Format("{0} {1}",
                              i, " Buzz");
                    sb.AppendLine(output);
                }
                else if (i % 3 == 0)
                {
                    string output = String.Format("{0} {1}",
                             i, " Fizz");
                    sb.AppendLine(output);
                }
                else
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
