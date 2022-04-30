namespace _05_study
{
    class Program
    {
        static void Main(String[] args)
        {
            // 设置Console颜色
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hello world");

            /* Class
             * [public] class 类名
             * {
             *      字段
             *      属性
             *      方法
             * }
             * 
             * 类不占内存, 对象占内存
             */

            Person p = new Person();
            p.Name = "woody";
            p.Output();
            p.Age = 10;
            // p.Email = "xx";

            Person.DoSth();

        }
    }
}