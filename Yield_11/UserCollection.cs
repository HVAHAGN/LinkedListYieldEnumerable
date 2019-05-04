using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_11
{
    class UserCollection
    {
        public static IEnumerable<string> Power()
        {
            yield return "Hello world!";
        }
    }
}
