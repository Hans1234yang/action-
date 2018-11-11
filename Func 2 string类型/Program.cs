using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_2_string类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> f1 = new Func<string, string, string>(Sayhi);

            string result = f1("Hans  ","你好");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public  static string Sayhi(string a,string b)
        {
            return a + b;
        }

    }
}
