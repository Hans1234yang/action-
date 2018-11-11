using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func4_lambda_int类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> f1 = new Func<int, int, int>
                (
                (int a,int b) => { return a + b; }
                );
           int result= f1(1,2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
