using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action3
{
    class Program
    {
        //action 3指向 无参数的lambda  action变量的 实例化可以偷懒， 不用写 new Action
        static void Main(string[] args)
        {
            Action action3 = (
                
                () => { Console.WriteLine("你好，世界");}
            );

            action3();
            Console.ReadLine();
        }
    }
}
