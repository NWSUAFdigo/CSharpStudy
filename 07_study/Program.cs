using System.Runtime.Serialization.Formatters.Binary;

namespace _07_study
{
    class Program1
    {
        static void Main1(String[] args)
        {
            // 对于父类变量指向子类对象, 默认调用的是父类的方法
            // 如果需要将父类变量调用对应的子类对象, 需要添加虚方法(virtual/override)
            Person p = new Student();
            p.SayHello();
        }
    }

    class Program2
    {
        static void Main2(String[] args)
        {
            AbstractModel model = new Model();
            model.SayHello();

            int num = 10;
            Test(out num);
            Console.WriteLine(num);
        }

        static void Test(out int num)
        {
            num = 0;
            num += 10;
        }
    }

    /* 访问修饰符
     * public
     * private
     * protected: 子类访问
     * internal: 当前程序集(项目)中访问, 类似于Java缺省修饰符
     * protected internal: 本项目子类访问
     * 
     * class级别修饰符只有: public/internal(默认)
     * class成员级别修饰符: 五个都可以
     * 子类级别的修饰符不能大于父类的修饰符, 因为这样会暴露父类成员
     */

    public class Program
    {
        static void Main(String[] args)
        {
            // Serialize();
            Deserialize();
        }

        private static void Deserialize()
        {
            using (FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\model.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(fs);
                Console.WriteLine(obj);
            }
        }

        private static void Serialize()
        {
            SerializeModel model = new SerializeModel();
            model.Name = "hello";
            model.Id = "12";

            // 序列化后存入文件
            using (FileStream fs = new FileStream(@"C:\Users\Administrator\Desktop\model.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, model);

            }
        }
    }
}