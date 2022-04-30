using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    /* 接口: interface
     */
    internal interface InterfaceModel
    {
        // 不允许添加访问修饰符
        void SayHello();

        // 不能包含字段, 可以包含静态字段
        static string _name;

        // 可以包含自动属性(本质仍然是方法)
        string Age
        {
            get; set;
        }
    }

    internal interface I1
    {
        void Test1();
    }

    internal interface I2
    {
        void Test2();
    }

    /*
     * 接口允许多继承
     */
    internal interface I3 : I1, I2
    {

    }

    internal class C1
    {

    }

    /*
     * 如果类同时有继承和实现, 则父类必须写在第一个, 即父类在前, 接口在后
     */
    internal class C2 : C1, I1, I2
    {
        // 接口方法的实现必须添加public修饰符
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        /* 显式实现接口
         * 如果类中的方法和接口方法重名, 可以显式的用 接口. 来实现接口方法
         * 此时, 如果通过接口变量引用实现对象, 则访问的是接口方法
         * 如果通过类变量引用实现对象, 则访问的是类方法
         * 
         * **此时, 无法添加访问权限修饰符**
         */

        void I1.Test1()
        {

        }
    }
}
