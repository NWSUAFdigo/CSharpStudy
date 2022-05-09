using System.Diagnostics;

namespace _09_study
{
    class Program1
    {
        static void Main1(String[] args)
        {
            // 通过进程打开应用程序
            //Process.Start("notepad");
            // 通过进程打开文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\core.pdf");
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }

    // 委托: 类似于Java的lambda表达式
    delegate void SayHi(string name);

    class Program2
    {
        static void Main2(String[] args)
        {
            SayHi sayHi = new SayHi(SayHiChinese); // 与下一句等价
            sayHi("张三");

            SayHi sayHi2 = SayHiChinese; // 与上一句等价, 编译器自动转换为上一句格式
            sayHi2("李四");

            // 匿名函数
            SayHi sayHi3 = delegate (string name)
            {
                Console.WriteLine(name);
            };
            sayHi3("嘻嘻嘻");

            // lambda表达式(语法与Java相同, 单参数省略类型和()号)
            SayHi sayHi4 = name =>
            {
                Console.WriteLine("lambda, name = {0}", name);
            };
            sayHi4("顶顶顶");
        }

        static void SayHiChinese(string name)
        {
            Console.WriteLine("你好, {0}", name);
        }
    }

    // 泛型委托, 泛型需要加到委托类型的后面
    delegate string TestDel<T>(T t);

    class Program
    {
        static void Main(String[] args)
        {
            TestDel<string> testDel = t =>
           {
               return t.ToString();
           };

            TestDel<int> testDel2 = Test1;
            testDel2(10);
            TestDel<string> testDel3 = Test2; // 创建委托实例时, 泛型需要指定
            testDel3("hello");
        }

        static string Test1(int num)
        {
            return "aaa" + num.ToString();
        }

        // 泛型方法的泛型写在方法名后面
        static string Test2<T>(T t)
        {
            return "bbb" + t.ToString();
        }
    }
}