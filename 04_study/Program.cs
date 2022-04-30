namespace CSharpLangStudy
{
    class Program1
    {
        static void Main1(String[] args)
        {
            // Convert.ToInt32() 与 int.Parse()
            // 本质相同, Convert内部调用int.Parse
            string str = "123";
            int num1 = Convert.ToInt32(str);
            int num2 = int.Parse(str);

            int num = 100;
            bool flag = int.TryParse("123a", out num);
            Console.WriteLine("flag = {0}, num = {1}", flag, num);
        }

        /* 单句调试
         * 快捷键: F11 进入, F11 下一句
         * 可以添加监视, 调试菜单(debug状态), 新增监视
         * 可以监视变量, 或者表达式, 如果值刚刚发生改变则会变红
         */

        /* 断点调试
         * 在行号前的灰框中点击添加断点, 点击实心启动按钮开启debug
         * F11, 下一句; shift + F11, 跳出
         */
    }

    class Program2
    {
        static void Main2(String[] args)
        {
            /* 常量
             * const 数据类型 变量名 = 值;
             */

            const string str = "123";
            // str = "hello"; 语句报错
        }
    }

    class Program3
    {
        static void Main3(String[] args)
        {
            /* 枚举
             * [public] enum 枚举名
             * {
             *      值1,
             *      值2,
             *      ...
             * }
             * 
             * [public] 表示可以省略
             */

            // 枚举使用
            Gender m = Gender.男;
        }
    }

    /*
     * 将枚举声明到namespace的下面
     * 枚举是一个变量类型
     */
    public enum Gender
    {
        男,
        女
    }

    class Program4
    {
        static void Main4(String[] args)
        {
            /* 枚举与int可以相互转换
             * 如无声明, 枚举值默认从0开始
             */
            Console.WriteLine((int)State.INTERUPT);
            Console.WriteLine((State)2);

            /* 枚举.ToString() 转换位字符串
             */
            Console.WriteLine(State.STOP.ToString());

            /* 字符串转为Enum
             * str可以是数字, 或者枚举变量值
             * 如果是数字, 则不会报错, 无对应枚举时输出原值
             * 如果是枚举变量值, 则需要保证字符一致(大小写一样), 否则报错
             */
            //string str = "2"; 
            //string str = "stop"; 
            string str = "STOP";
            State state = (State)Enum.Parse(typeof(State), str);
            Console.WriteLine(state.ToString());
        }
    }

    public enum State
    {
        START = 2,
        STOP,
        DOING = 1,
        INTERUPT
    }

    class Program5
    {
        static void Main5(String[] args)
        {
            /*
             * 结构
             * [public] struct 结构名
             * {
             *      字段;
             *      字段;
             *      .....
             * }
             * 
             * **规范要求: 字段名以_开头**
             * 字段需要添加修饰符才能访问
             */

            // 结构声明与使用
            User u;
            u._name = "hello";
            u._phone = "4001234567";

        }
    }

    // 结构定义
    public struct User
    {
        public string _name;
        public string _email;
        public string _password;
        public string _phone;
    }

    class Program6
    {
        static void Main6(String[] args)
        {
            /* 数组
             * 类型[] 变量 = new 类型[count];
             * 类型[] 变量 = {值, 值, ...};
             * 类型[] 变量 = new 类型[count]{值, 值...};
             * 类型[] 变量 = new 类型[]{值, 值...};
             */
            int[] arr = new int[4];
            Console.WriteLine(arr);
            int[] arr2 = { 1, 2, 4 };
            int[] arr3 = new int[4] { 1, 2, 3, 5 };
            int[] arr4 = new int[] { 1, 2, 3, 5 };
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            /* 方法
             * [public] [static] 返回类型 方法名 (参数列表)
             * {
             *      // 方法体
             *      [return 返回值;]
             * }
             */

            /* out形参修饰
             * out参数作为多余的返回值返回
             * out参数在方法内必须赋值
             */
            int[] arr = { 1, 2, 478, 32, 5, 2346, 43, 57, 3457, 23, 45 };

            int avg;
            int length;
            cal(arr, out avg, out length);
            Console.WriteLine("avg = {0}, length = {1}", avg, length);

            /* ref形参修饰
             * 将参数作为引用传递
             * ref参数要求方法外必须赋值, 方法内可以不再次赋值
             */
            int num = 49;
            test(ref num);
            Console.WriteLine(num);

            /* params形参修饰
             * 将修饰的参数作为可变参数. params表明用一个形参接收多个是实参值
             * params参数也可以传入对应的数组
             */
            int ret;
            sum(out ret, 34, 52, 346, 2, 6, 3467, 234, 6, 347);
            Console.WriteLine("sum = {0}", ret);
        
            /* 方法重载
             * 方法名相同, 参数列表不同
             */
        }

        public static void cal(int[] arr, out int avg, out int length)
        {
            length = arr.Length;
            avg = (int)arr.Average();
        }

        public static void test(ref int num)
        {
            num++;
        }

        public static void sum(out int ret, params int[] arr)
        {
            ret = arr.Sum();
        }
    }
}