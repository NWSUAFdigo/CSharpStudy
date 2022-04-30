using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    /* 部分类: partial
     * 标记为partial的类, 可以允许在一个命名空间内写多个类, 所有这些类共同组成了这个类
     * 其不受访问权限的限制, 因为本质上这是一个类
     * 部分类中不允许出现重复的字段/方法/属性, 也就是说部分类不存在交集
     */
    internal partial class PartialModel
    {
        private int _id;
    }

    internal partial class PartialModel
    {
        // private int _id;
        public int Id { get { return _id; } set { _id = value; } }
    }
}
