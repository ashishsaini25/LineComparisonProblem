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
            Comparison comparison = new Comparison(1, 2, 3, 4);
            comparison.Calculate();
        }
    }
}
