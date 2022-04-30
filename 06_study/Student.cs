using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_study
{
    /* 继承
     * 1. 单继承
     */
    public class Student : Person
    {

        // 子类调用父类的构造函数 :base()
        public Student() : base()
        {
        }

        /*
         * 子类和父类的同名方法, 使用new关键字表示该操作是有意为之
         */
        public new void sayHello()
        {
            Console.WriteLine("Student sayHello");
        }

        /* protected修饰符: 父类和子类中访问, 其他类无法访问
         */
    }
}
