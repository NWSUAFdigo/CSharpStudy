namespace _08_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������̨�߳�ִ�д���, �����ݲ���(�������ͱ�����object)
            Thread t = new Thread(Test);
            t.IsBackground = true;
            t.Start("hello");
        }

        private void Test(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("obj = {0}, i = {1}", obj, i);
            }
        }
    }
}