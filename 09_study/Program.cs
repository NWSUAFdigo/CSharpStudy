using System.Diagnostics;

namespace _09_study
{
    class Program
    {
        static void Main(String[] args)
        {
            // 通过进程打开应用程序
            //Process.Start("notepad");
            // 通过进程打开文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\core.pdf");
            psi.UseShellExecute = true;
            Process.Start(psi);
        }
    }
}