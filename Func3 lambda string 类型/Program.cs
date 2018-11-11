using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func3_lambda_string_类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> f1 = new Func<string, string, string>
                (
                   (string a,string b) => { return a + b; }
                );

           string result= f1("Hello ","hans");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
