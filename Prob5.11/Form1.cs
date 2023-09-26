namespace Prob5._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBox1.Text);
            if (number < 0)
            {
                errorLabel.Text = "Please enter a nonnegative integer";
                return;
            }
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            resultTextBox.Text = result.ToString();
            errorLabel.Text = "";
        }
    }
}