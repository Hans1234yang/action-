using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action1
{
    class Program
    {
        // action 没有 参数没有返回值的 方法
        static void Main(string[] args)
        {
            //实例化一个 action
            Action action1 = new Action(SayHi);
            action1();
            Console.ReadKey();
        }

        //写一个方法
        static void SayHi()
        {
            Console.WriteLine("hello");
        }
    }
}
