using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    class Program
    {
        //1.action 没有 参数，没有返回值的方法  
        static void Main(string[] args)
        {
            Action action = new Action();
        }

        static void SayHello()
        {
            Console.WriteLine("你好啊，世界");
        }
    }
}
