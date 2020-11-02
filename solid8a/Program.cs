using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid8a
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sqrt(-5);
                
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }
        }
       static int Sqrt(int num)
        {
            if (num < 0)
                throw new ArgumentException("The number must be positive");
            //...    }
            return 0;

        }
    }
}