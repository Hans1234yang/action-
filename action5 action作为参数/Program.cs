using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action5_action作为参数
{
    //action 作为参数使用。   没有参数的action
    class Program
    {
        public static Action action5;       
        static void Main(string[] args)
        {
            Action testAction = (
                  () => { Console.WriteLine("你好，世界"); }
                );

            //调用Hello方法的时候，传一个action变量
            Hello(testAction);
            Hello(
                () => { Console.WriteLine("你好哦，携程"); }
             );

            //这两种写法是一样的。 传一个action 变量和 传lambda表达式的效果是一样的 。 
            //d但是第一种写法相对比较工整一些

   
            
            Console.ReadLine();
        }

        static void Hello(Action _action5)
        {
            action5 = _action5;

            action5();

        }
    }
}
