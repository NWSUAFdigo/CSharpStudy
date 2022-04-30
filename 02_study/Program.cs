namespace CSharpLangStudy
{
    class Program1
    {
        static void Main1(String[] args)
        {
            // 变量定义
            int num;
            // 变量赋值. 赋值后方可使用
            num = 100;
            // 定义并赋值
            int num2 = 100;
            // 小数类型 精度15~16位
            double num3 = 3.14;
            double num4 = 3;
            // 字符串
            string str = "hello";
            // 字符
            char c = 'a';
            // 字符: 只能有一个, 不能多, 不能少
            // char d = ''; 错误
            // char e = 'bc'; 错误

            // 精度浮点类型 精度28~29位
            decimal d = 1.245M; // M/m不能少
        }
    }

    class Program2
    {
        static void Main2(String[] args)
        {
            // 蓝色字体为C#特有的关键字
            // 绿色字体为Class类
            string str = "hello";
            String str2 = "hello";
            // 两者没有区别

            // 变量命名规范
            /*
             * 开头: 字母/下划线/@符号
             * 后续: 字母/数字/下划线
             * **大小写敏感**
             * 驼峰命名. 首字母小写
             * **类/方法命名规范** 驼峰命名. 首字母大写. 注意方法命名规范
             */
        }
    }

    class Program3
    {
        static void Main3(String[] args)
        {
            string str = "hello";
            Console.WriteLine("你好" + str);
            // 占位符
            int num1 = 100;
            int num2 = 120;
            int num3 = 3;
            // 输出顺序以{数字}为准
            Console.WriteLine("num1={0}, num2={1}, num3={2}", num1, num2, num3);
            Console.WriteLine("num1={1}, num2={2}, num3={0}", num1, num2, num3);

            // 小数位数控制输出
            double num4 = 3;
            Console.WriteLine("两位小数{0:0.00, 四位小数{1:0.0000}", num4, num4);
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            // 接收输入一行内容
            string str = Console.ReadLine();
            Console.WriteLine("input str is {0}", str);
            // 字符串的转义符
            /*
             * \n : 换行
             * \" : "
             * \t : tab
             * \b : backspace 删除前面一个字符. 在字符串的开头和结束没有效果
             * \r\n : Windows操作系统换行符(文件写入时使用)
             * \\ : \
             * @ : 1. 取消\的转义作用, 单纯表示为一个斜线, 常用于文件路径 2. 保留字符串的原格式输出
             */

            string path = @"E:\csharp-workspace\Csharp-demo\CSharpLangStudy";
            Console.WriteLine(path);

            path = @"hello 
world";
            Console.WriteLine(path);

            // 赋值运算 + - * / %
            // 隐式类型转换和Java相同, 显式类型转换和Java相同
        }
    }
}