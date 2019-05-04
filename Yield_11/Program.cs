using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Yield_11
{
    class Program
    {
        static void Main(string[] args)
        {

           foreach(string user in UserCollection.Power())
            {
                Console.WriteLine(user);
            }



            Console.WriteLine(new string('*',10));

            IEnumerable enumerable = UserCollection.Power();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string item = enumerator.Current as String;
                Console.WriteLine(item);
            }



            Console.ReadLine();
            
        }
    }
}
