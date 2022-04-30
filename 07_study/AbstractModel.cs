using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    /*
     * 抽象类
     */
    public abstract class AbstractModel
    {
        /*
         * 抽象方法必须添加abstract关键字, 且无实现
         */
        public abstract void SayHello();

        /*
         * 抽象属性
         */
        public abstract int Id { get; set; }

        /*
         * 抽象类中可以包含具体方法
         */
        public void Hello()
        {
            Console.WriteLine("hello method");
        }

        /*
         * 抽象类中可以包含虚方法
         */
        public virtual void TestVirtual()
        {

        }
    }
}
