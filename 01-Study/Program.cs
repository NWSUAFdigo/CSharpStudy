namespace CSharpLangStudy
{
    class Program
    {
        /// <summary>
        /// 文档注释-Main方法
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            // 单行注释
            /*
             * 多行注释
             */
            /// 文档注释

            // 输出
            Console.WriteLine("hello world");
            // 输入一个字符并输出到控制台
            Console.ReadKey();

            /*
             * 快捷键
             * Ctrl + K, D : 格式化代码
             * Ctrl + J : 智能提示
             * Shirt + Home/End : 全选一行(开始/结束)
             * Ctrl + K, C : 注释所选代码
             * Ctrl + K, U : 取消注释所选代码
             * Ctrl + L : 删除整行
             */

            // 折叠冗余代码
            #region 测试折叠
            Console.WriteLine("hello");
            #endregion
        }
    }
}
