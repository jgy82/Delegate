using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareDelegate
{
    public delegate double Calc(double x, double y);        // 自定义委托:位置在名称空间首,double是目标方法返回值类型,()内是目标方法参数列表.括号外的double和括号内的double是类型约束

    class Program
    {
        public delegate double Calc2(double x, double y);       // 嵌套类

        static void Main(string[] args)
        {
            Type t = typeof(Action);
            Console.WriteLine(t.IsClass);       // 判断t这个变量是否是类类型

            Caculator caculator = new Caculator();      // 创建类的实例后才能访问实例方法
            Calc calc1 = new Calc(caculator.Add);       // 创建委托的实例,()内是委托指向的目标方法
            double a = 100;
            double b = 200;
            double c = 0;
            Console.WriteLine(calc1(a, b));     // 简写法
            Console.WriteLine(calc1.Invoke(a, b));

            Program.Calc2 calc2 = new Calc2(caculator.Add);     // 调用嵌套类前加父类前缀
        }
    }
    class Caculator     // 该类内方法参数和返回值类型全部一样
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
