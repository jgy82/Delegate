using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculator caculator = new Caculator();

            Action action = new Action(caculator.Report);       // 常用委托Action委托,指向caculator.Report方法.此处caculator.Report中Report不加(),意为此处仅使用方法名称,不调用该方法
            caculator.Report();     // 直接调用方法
            action.Invoke();        // 用委托调用方法,invoke意为调用
            action();               // 委托简记写法,模仿C指针

            Func<int, int, int> func1 = new Func<int, int, int>(caculator.Add);     // 常用委托泛型委托Func<>,<>内是目标方法参数类型和一个Tresult返回值类型:<参数类型1,参数类型2,返回值类型3>.
            Func<int, int, int> func2 = new Func<int, int, int>(caculator.Sub);
            int x = 100;
            int y = 200;
            int z = 0;
            z = func1.Invoke(x, y);
            z = func1(x, y);        // 函数指针式写法
            Console.WriteLine("\n{0} + {1} = {2}", x, y, z);
            z = func2.Invoke(x, y);
            z = func2(x, y);        // 函数指针式写法
            Console.WriteLine("{0} - {1} = {2}", x, y, z);
        }
    }
    class Caculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
