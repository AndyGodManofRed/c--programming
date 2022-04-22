namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string direction = "";
        private int i = 0,limit=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                // groupBox1.Left+groupBox1.Width+label1.Width
                //label1.Left + label1.Width代表label的右端
                if (label1.Left + label1.Width > 0)//label的右端，父容器最左端的右邊
                {
                    label1.Left = label1.Left - 5;
                }
                //label1.Width=149   -149~-154是label會超出父元件的距離
                else if (label1.Left < 1)//label1.Left < -label1.Width -5 =false
                {
                    label1.Left = 507;
                }
            }
            else
            {
                if (label1.Left<507)//label的左端，沒超過父容器的最右邊
                {
                    label1.Left = label1.Left + 5;
                }
                else if (label1.Left > 1)//label1.Left>1，1只是為了能讓他進入else if
                {
                    label1.Left = -label1.Width;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text= textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
            label1.Text = "Testing....";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            direction = "left";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            direction = "right";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                timer1.Enabled = false;
                button3.Text = "繼續";
                i++;    
            }
            else
            {
                timer1.Enabled = true;
                button3.Text = "暫停";
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (limit >=0 )
            {
                timer1.Interval += 10;
                limit--;
                button4.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (limit <= 5)
            {
                timer1.Interval -= 10;
                limit++;
                button5.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }
    }
}