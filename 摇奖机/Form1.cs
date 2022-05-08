namespace 摇奖机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 使用一个变量记录开始/停止
        bool stop;

        private void button1_Click(object sender, EventArgs e)
        {
            // 修改名称
            Button btn = (Button)sender;
            if (btn.Text == "开始")
            {
                btn.Text = "暂停";
                stop = false;
                // 启动摇奖机
                Thread t = new Thread(Play);
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                btn.Text = "开始";
                stop = true;
            }
        }

        private void Play()
        {
            Random random = new Random();
            while (!stop)
            {
                label1.Text = random.Next(1, 10).ToString();
                label2.Text = random.Next(1, 10).ToString();
                label3.Text = random.Next(1, 10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}