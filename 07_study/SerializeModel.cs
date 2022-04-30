using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_study
{
    /*
     * internal: 本项目使用, 外部项目不能使用
     */
    [Serializable] // 类似于注解?
    internal class SerializeModel
    {
        private string _id;
        private string _name;

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
