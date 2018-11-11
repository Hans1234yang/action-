using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action4
{
    class Program
    {
        //指向 有参数的Lambda 
        static void Main(string[] args)
        {
            Action<string> action4 = (
                 (string name) => { Console.WriteLine("你好  {0}", name); }
                );

            action4("杨先生");
            Console.ReadLine();
        }
    }
}
