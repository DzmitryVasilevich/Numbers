
using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Numbers
{    
    class Program
    {
       static void Main(string[] args)
        {
            var dict = new Dictionary<int, string>();
            
            var r = IntegersProcessing.RecieveNumbers(dict);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        } 
    }
}