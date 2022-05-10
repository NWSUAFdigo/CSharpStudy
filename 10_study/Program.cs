using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_study
{
    // Attribute 基本等同于Java注解, 使用方式略有不同
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            int num = 0;
            int ret = 10;
            Test(ref num, out ret);
            Console.WriteLine("num = {0}, ret = {1}", num, ret);

            Console.ReadKey();
        }

        private static void Test(ref int num, out int ret)
        {
            num++;

            ret = num++;
        }

    }
}
