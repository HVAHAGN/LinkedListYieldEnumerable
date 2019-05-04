using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_12
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in UserCollection.Power())
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
