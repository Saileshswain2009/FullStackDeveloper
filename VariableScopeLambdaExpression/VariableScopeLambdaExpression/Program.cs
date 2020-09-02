using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VariableScopeLambdaExpression
{
    class Program
    {
        delegate bool D();
        delegate bool D1(int i);

        class Test
        {
            D del;
            D1 del1;

            public void TestMethod(int input)
            {
                int j = 0;
                del = () => { j = 10; return j > input; };
                del1 = (x) => { return x == j; };
                Console.WriteLine(j);
                bool boolResult = del();
                Console.WriteLine("j={0}.b={1}", j, boolResult);
            }
            static void Main(string[] args)
            {
                Test t = new Test();
                t.TestMethod(5);
                bool result = t.del1(2);
                Console.WriteLine(result);

            }
        }
    }
}
