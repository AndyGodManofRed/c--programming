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
                //label1.Left + label1.Width�N��label���k��
                if (label1.Left + label1.Width > 0)//label���k�ݡA���e���̥��ݪ��k��
                {
                    label1.Left = label1.Left - 5;
                }
                //label1.Width=149   -149~-154�Olabel�|�W�X�����󪺶Z��
                else if (label1.Left < 1)//label1.Left < -label1.Width -5 =false
                {
                    label1.Left = 507;
                }
            }
            else
            {
                if (label1.Left<507)//label�����ݡA�S�W�L���e�����̥k��
                {
                    label1.Left = label1.Left + 5;
                }
                else if (label1.Left > 1)//label1.Left>1�A1�u�O���F�����L�i�Jelse if
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
                button3.Text = "�~��";
                i++;    
            }
            else
            {
                timer1.Enabled = true;
                button3.Text = "�Ȱ�";
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