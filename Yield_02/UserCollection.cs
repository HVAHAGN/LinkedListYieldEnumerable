using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Yield_12
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            return new ClassPower();
        }
        public sealed class ClassPower: IEnumerable<string>, IEnumerator<string>
        {
            private int state;
            private string current;
            public string Current { get { return current; } }

            object IEnumerator.Current { get { return Current; } }

            public void Dispose()
            {
                Reset();
            }

            public void Reset()
            {
                state = -1;
            }

            public IEnumerator<string> GetEnumerator()
            {
                state = 0;
                return this;
            }
            public bool MoveNext()
            {
                switch (state)
                {
                    case 0:
                        current = "Hello";
                        state = 1;
                        return true;
                    case 1:
                        state = -1;
                        break;
                }
                return false;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

    }
}
