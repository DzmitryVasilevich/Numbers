using System;
using System.Text;

namespace Project_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is multiplicity for the 1st word?");
            var multiplicity1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the 1st word?");
            var word1 = Console.ReadLine();


            Console.WriteLine("What is multiplicity for the 2nd word?");
            var multiplicity2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the 2nd word?");
            var word2 = Console.ReadLine();


            Console.WriteLine("What is multiplicity for the 3rd word?");
            var multiplicity3 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the 3rd word?");
            var word3 = Console.ReadLine();

            var sb = new StringBuilder();
            for (int i = 0; i <= 100; i++)
            {                
                if (i % multiplicity1 == 0)
                {
                    string output = String.Format($"{i} {word1}");
                    sb.AppendLine(output);
                }
                else if (i % multiplicity2 == 0)
                {
                    string output = String.Format($"{i} {word2}");
                    sb.AppendLine(output);
                }
                else if (i % multiplicity3 == 0)
                {
                    string output = String.Format($"{i} {word3}");
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
