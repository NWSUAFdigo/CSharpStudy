namespace CSharpLangStudy
{
    class Program1
    {
        static void Main1(String[] args)
        {
            // Convert类进行转换
            string str = "123";
            int num = Convert.ToInt32(str);
            Console.WriteLine("num : {0}", num);
            double d = Convert.ToDouble(str);
            Console.WriteLine("double: {0}", d);

            // ++/-- 与Java相同
            // ++ 属于一元运算符, +属于二元运算符, 一元运算符优先级高于二元运算符

            // 关系运算符 > < >= <= != ==
            // 布尔类型 bool
            bool b = 12 >= 20;
            Console.WriteLine(b);
            // 逻辑运算符 & && | || !
        }
    }

    class Program2
    {
        static void Main2(String[] args)
        {
            /* if结构
             * if (condition)
             * {
             *      // todo
             * }
             */

            /* if-else结构 (注意格式化后的花括号位置)
             * if ()
             * {
             *      // todo
             * }
             * else
             * {
             *      // todo
             * }
             */

        }
    }

    class Program3
    {
        static void Main3(String[] args)
        {
            /* try-catch
             * try
             * {
             *      // todo
             * }
             * catch
             * {
             *      // catch todo
             * }
             */
        }
    }

    class Program4
    {
        static void Main4(String[] args)
        {
            /* switch
             * switch (var)
             * {
             *      case const: 
             *      // todo
             *      break;
             *      
             *      default :
             *      break; // ****注意: default 也需要break****
             * }
             * 
             * **注意: 同Java一样, 仍然存在穿透**
             */

            int num = 10;
            switch (num)
            {
                case 0:
                // todo
                case 1:
                // todo
                default:
                    // todo
                    Console.WriteLine("num = {0}", num);
                    break;
            }
        }
    }

    class Program5
    {
        static void Main5(String[] args)
        {
            /* while
             * while (condition)
             * {
             *      // todo
             *      // break;
             *      // continue;
             * }
             */

            int num = 20;
            while (num > 0)
            {
                Console.WriteLine("num = {0}", num);
                num--;
                if (num == 10)
                {
                    continue;
                }
            }
        }
    }

    class Program
    {
        static void Main(String[] args)
        { 
            /* do-while
             * do 
             * {
             *      // todo
             * } while (condition);
             */

            /* for
             * for (first express; condition; last express)
             * {
             *      // todo
             * }
             */

            /* 三元表达式(三目运算符)
             * 
             * bool表达式 ? 语句1 : 语句2
             */
        }
    }
}