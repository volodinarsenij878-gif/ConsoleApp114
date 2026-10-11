using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program71
{
    internal class Program
    {
        static void Main()
        {
            bool result = (5 > 3) && !(10 <= 2) || (4 == 5);
            Console.WriteLine(result); // True
        }
    }
}
