using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class first
    {
        int x = 100;
        static void Main(string[] args)
        {
            first f1 = new first();
            first f2 = f1;
            Console.WriteLine(f1.x + " " + f2.x);
            Console.ReadLine();
        }
    }
}
