namespace GuessTheNum
{
    public partial class Form1 : Form
    {
        int defaultvalue;
        int numOfAttempts;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numOfAttempts > 0)
            {
                try
                {
                    int value = int.Parse(textBox1.Text);
                    if (numOfAttempts > 1)
                    {
                        numOfAttempts--;
                        if (value == defaultvalue)
                        {
                            textBox2.Text = "Congratulations! You've guessed the number!";
                        }
                        else if (value < defaultvalue)
                        {
                            textBox2.Text = $"Too low! you have {numOfAttempts} guesses";
                        }
                        else
                        {
                            textBox2.Text = $"Too high! you have {numOfAttempts} guesses";
                        }
                    }
                    else
                    {

                        if (value == defaultvalue)
                        {
                            textBox2.Text = "Congratulations! You've guessed the number!";
                        }
                        else
                        {
                            textBox2.Text = "Womp womp you lost. Select Difficulty to play again";
                            selectDifButton.Enabled = true;
                            button1.Enabled = false;
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("please enter valid value (number)");
                }

            }
            textBox1.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectDifButton.Enabled)
            {
                numOfAttempts = 3;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (selectDifButton.Enabled)
            {
                numOfAttempts = 5;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (selectDifButton.Enabled)
            {
                numOfAttempts = 8;
            }
        }

        private void selectDifButton_Click_1(object sender, EventArgs e)
        {
            if (numOfAttempts > 0)
            {
                Random random = new Random();
                defaultvalue = random.Next(0, 101);
                textBox2.Text = "Game started! enter your number!";
                textBox1.Text = "";
                selectDifButton.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("first select difficulty");
            }
        }
    }
}