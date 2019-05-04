using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_13
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> test = CreateRandomEnumerable(100);
            List<int> test1 = test.ToList();
            List<int> list = CreateRandomEnumerable(100).ToList();

            List<int> listEven = list.EvenNumbers();
            List<int> listGreat = list.GreaterThan(15);
            foreach (var item in listEven)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(new string('*',50));
            foreach (var item in listGreat)
            {
                Console.Write(item+" ");
            }

            Console.ReadLine();
        }


        static IEnumerable<int> CreateRandomEnumerable(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                yield return rnd.Next(1, 200);
            }
        }
    }
}
