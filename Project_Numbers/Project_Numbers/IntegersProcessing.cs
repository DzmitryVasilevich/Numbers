using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Numbers
{
   public static class IntegersProcessing
    {
        public static List<string> RecieveNumbers(Dictionary<int, string> numericsAndWords)
        {
            var result = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                foreach (var item in numericsAndWords)
                {
                    if (i % item.Key == 0)
                    {
                        result.Add($"{i}{item.Value}");
                    }
                }
            }
            return result;
        }
    }
}
