using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func1_int类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> f1 = new Func<int, int, int>(Add);

            int result = f1(1,2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add(int a ,int b)
        {
            return a + b;
        }
    }
}
