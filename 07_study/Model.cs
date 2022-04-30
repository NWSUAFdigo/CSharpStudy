using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    /*
     * 继承抽象类, 抽象方法/属性必须要实现
     */
    public class Model : AbstractModel
    {
        public override int Id { get; set; }

        public override void SayHello()
        {
            Console.WriteLine("model sayHello");
        }
    }
}
