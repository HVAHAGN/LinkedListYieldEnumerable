using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = CreateRandomEnumberable(50).ToList();
            List<int> result = list
                .EvenNumbers()
                .GreaterThan(100)
                .ToList();

            foreach (var item in result)
            {
                Console.Write(item+" ");
            }

            Console.ReadLine();
        }

        static IEnumerable<int> CreateRandomEnumberable(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                yield return rnd.Next(1, 200);
            }
        }
    }
}
