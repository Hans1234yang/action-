using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action2
{
    class Program
    {
        // 有参数无返回值的action
        static void Main(string[] args)
        {
            Action<string> action2 = new Action<string>(SayHi);   //委托类型的参数 一定要和 方法的参数 类型一致
            action2("杨先生");
            Console.ReadLine();

        }

        static void SayHi(string name)
        {
            Console.WriteLine("你好 "+name);
        }
    }
}
