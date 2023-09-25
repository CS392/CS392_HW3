using System;
namespace Prob5._10
{
    public partial class Form1 : Form
    {
        int num;
        Random random = new Random();
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
            randomNumber = random.Next(1, 101);
            randomNum.Text = "The right answer is(for testing)" + randomNumber.ToString();
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(Input.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Cannot convert to integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow. The number is too large to fit in an int.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == randomNumber)
            {
                Hint.Text = "You got it!";
                randomNumber = random.Next(1, 101);
                randomNum.Text = "The right answer is(for testing) " + randomNumber.ToString();
            }
            else if (num < randomNumber)
            {
                Hint.Text = "Too Low";
            }
            else
            {
                Hint.Text = "Too High";
            }
        }
    }
}