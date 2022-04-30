using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_study
{
    public class Person
    {
        // 字段
        string _name; // 修改_name字段的访问权限为缺省, 即private
        public string _email;
        public string _phone;
        public string _city;
        public string _zipcode;
        public string _country;
        public string _country_code;
        public string _country_name;
        public string _country_phone;
        public string _country_city;
        public string _country_zipcode;

        // 属性
        /// <summary>
        /// _name属性
        /// </summary>
        public string Name // 属性名称首字母大写, 类似于方法
        {
            get { return _name; }
            set { _name = value; }
        }

        static int _age;

        // 实例属性可以引用静态字段
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // 静态属性无法引用非静态字段
        // 自动属性, get/set无方法体. 程序默认添加一个隐藏字段用于接收数据
        public static string Email
        {
            get; // { return _email; }
            set; // { _email = value; }
        }

        // 静态方法 类名.方法()
        // 实例对象无法调用自身静态方法, 只能通过类名调用. 注意与Java的区别
        public static void DoSth()
        {
            Console.WriteLine("do something...");
        }

        // 实例方法 对象.方法()
        public void Output()
        {
            Console.WriteLine("output something...");
        }

        // 构造函数, 与Java完全相同
        // 构造函数重载时的调用语法与Java不同
        public Person() : this(null, null)
        {

        }

        public Person(string name, string email)
        {
            this.Name = name;
            this._email = email;
        }

        // 析构函数
        // 用于对象被回收前调用, 作用为释放资源
        // 在.NET中，由于GC的存在，究竟何时调用析构函数我们是不能确认的。
        ~Person()
        {
            Console.ReadKey();
        }
    }
}
