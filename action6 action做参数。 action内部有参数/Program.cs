using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action6_action做参数__action内部有参数
{
    class Program
    {

        public static Action<string> action;
        

        static void Main(string[] args)
        {
            Action<string> action6 = 
                (
                (string name) => { Console.WriteLine("Hello " + name); }
                );

            Hello(action6);
            Console.ReadLine();
        }

        public static void Hello(Action<string>_action)
        {
            action = _action;
            action("hans");
        }

      

      
       




    }
}
