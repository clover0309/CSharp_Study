namespace NumberGame
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        private int start = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("숫자만 입력가능합니다.");
                return;
            }

            if(!int.TryParse(textBox1.Text, out int inputNumber))
            {
                MessageBox.Show("숫자만 입력가능합니다.");
                return;
            }


                if (!(chance == 0) && start == 1)
                {
                    if (inputNumber == findNumber)
                    {
                        MessageBox.Show("게임에 이기셨습니다!!!!");
                        ResetGame();
                    }
                    else
                    {
                        chance = chance - 1;
                    if (chance > 0)
                        MessageBox.Show("기회는 " + chance + "번 남으셨습니다.");
                    else if (chance == 0) {
                        MessageBox.Show("게임에 지셨습니다. T_T");
                        ResetGame();
                        }
                        
                    }


                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var random_number = new Random();
            findNumber = random_number.Next(1, 20);
            chance = 3;
            start = 1;

            if(start == 1)
            {
                button2.Text = "게임이 시작되었습니다.";
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void ResetGame()
        {
            chance = 0;
            start = 0;
            textBox1.Clear();
            button2.Enabled = true;
            button2.Text = "게임 시작";
            button1.Enabled = false;
        }
    }
}
