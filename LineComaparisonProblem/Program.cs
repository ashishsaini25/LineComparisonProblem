using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComaparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparison line1 = new Comparison(3, 3, 3, 4);
            Comparison line2 = new Comparison(3, 2, 3, 4);
            if (line1.Calculate() == line2.Calculate())
            {
                Console.WriteLine("Both Lines Are Equal\n");
            }
            else
            {
                Console.WriteLine("Lines Are Not Equal\n");
            }
        }
    }
}
