using _05_study;
using System.Collections;
using System.Text;

namespace _06_study
{
    public class Program1
    {
        static void Main1(String[] args)
        {
            /* 在一个项目中引用另一个项目
             * 1. 在依赖项中右键添加引用项目
             * 2. 引用命名空间 using xxx;
             */
            Person person = new Person();


            /* 值类型 和 引用类型
             * 值类型 栈存储
             *  int double bool char decimal struct enum
             * 引用类型 堆存储
             *  string 自定义类 数组
             */

            /* 字符串
             * 字符串在内存中的不可变性(同Java)
             * 字符串==char[]
             */

            // 字符串转char数组
            string str = "hello";
            char[] arr = str.ToCharArray();
            arr[0] = 'a';
            str = new string(arr);

            // StringBuilder
            // 引用不同命名空间的类 快捷键: alt+shift+f10
            StringBuilder sb = new StringBuilder(100);
            sb.Append(str).Append("aaa");
            // 字符串转大小写
            str = str.ToLower();
            str = str.ToUpper();

            // 字符串忽略大小写比较
            bool flag = str.Equals("hello", StringComparison.OrdinalIgnoreCase);

            // 字符串分割
            string[] strArr = str.Split(',');
        }
    }

    public class Program2
    {
        static void Main2(String[] args)
        {
            Student student = new Student();
            student.Name = "hello";

            /* 里氏转换
             * 1. 子类对象赋值给父类变量
             * 2. 多态引用可以强转子类
             */

            Person p = new Student();
            Student stu = (Student)p;

            /* is/as
             * is 等同于 instanceof, 用于判断类型是否匹配
             * as 作为, 如果成功, 返回对象, 否则返回null
             */

            if (p is Student)
            {
                Console.WriteLine("var p is student");
            }

            Student stu2 = p as Student;
            Console.WriteLine(stu2);
        }
    }

    public class Program3
    {
        static void Main3(String[] args)
        {
            // ArrayList不同于Java, 可以存储任意类型数据, 无泛型
            ArrayList arrayList = new ArrayList();
            arrayList.Add("hello");
            arrayList.AddRange(new string[] { "aa", "bb" });
            // 使用下标取出元素
            Console.WriteLine(arrayList[0]);
            // 初始Capacity为0, 添加一个元素时Capacity为4, Capacity满时扩容一倍

            // Hashtable也是存储任意类型, 无泛型
            Hashtable hashtable = new Hashtable();
            hashtable.Add("hello", "hello");
            hashtable.Add(111, "3q3");
            // key不允许重复, 与Java不同
            // hashtable.Add(111, "dsadf");
            // 使用如下方式覆盖value
            hashtable[111] = "afasfd";
            // 取值
            Console.WriteLine(hashtable["hello"]);
            foreach (var item in hashtable)
            {
                // c#中存在隐式类型var, 其用法同其他弱类型语言相同, 一般不用
                Console.WriteLine(item);
            }
        }
    }

    public class Program4
    {
        static void Main4(String[] args)
        {
            /* 泛型List
             * List在C#中是一个class, 不是interface
             */
            List<string> list = new List<string>();
            list.Add("hello");

            /* 装箱和拆箱 (与Java不同概念)
             * 装箱: 值类型 -> 引用类型
             * 拆箱: 引用类型 -> 值类型
             * 装拆箱对性能消耗较大, 因尽量避免
             * 发生装拆箱的前提是两种类型存在继承关系
             */

            int num = 10;
            object obj = num;

            /* 泛型map
             */
            Dictionary<string, object> map = new Dictionary<string, object>();
            map.Add("hello", obj);
            Console.WriteLine(map["hello"]);

            foreach (KeyValuePair<string, object> item in map)
            {
                Console.WriteLine(item.Key, item.Value);
            }
        }
    }

    public class Program
    {
        static void Main(String[] args)
        {
            /* FileStream: 建立通道处理文件
             * File: 一次加载到内存处理文件
             * 
             * FileStream操作方式与Java FileInputStream类似
             */

            FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\a.txt", FileMode.OpenOrCreate);
            byte[] buffer = new byte[512];
            int len = 0;
            // offset为0, 同Java不太一样
            while ((len = fs.Read(buffer, 0, buffer.Length)) != 0)
            {
                Console.WriteLine(Encoding.Default.GetString(buffer, 0, len));
            }
            // 关闭流
            fs.Close();
            // 释放资源
            fs.Dispose();

            // 使用using自动释放资源, 类似于Java的try() catch操作
            using (FileStream fs2 = new FileStream(@"C:\Users\Administrator\Desktop\a.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "hello world";
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                fs2.Write(bytes, 0, bytes.Length);
            }

            Console.WriteLine("写入完成");
        
            /* 字符流
             * StreamReader/StreamWriter
             */
        }
    }
}