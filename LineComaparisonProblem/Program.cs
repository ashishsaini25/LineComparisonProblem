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
            if (line1.Calculate() > line2.Calculate())
            {
                Console.WriteLine("Length of line1 is greater than line2\n");
            }
            if(line1.Calculate()<line2.Calculate())
            {
                Console.WriteLine("Length of line1 is Samller than line2\n");
            }
            if (line1.Calculate() == line2.Calculate())
            {
                Console.WriteLine("Both lines are Equal\n");
            }
        }
    }
}
