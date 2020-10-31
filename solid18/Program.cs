using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid18
{
    class Program
    {
        public static int add(int x, int y) { return x + y; }

        static void Main(string[] args)
        {
            Func<int, int, int> myDelegate = add;
            Console.WriteLine(myDelegate(1, 1));
        }

    }
}
