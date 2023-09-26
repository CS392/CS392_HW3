namespace Time_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double time = int.Parse(textBox1.Text);
            if(time > 0 && time < 60)
            {
                textBox2.Text = Math.Round(time,2) + " seconds";
            } else if(time < 0)
            {
                textBox2.Text = "cannot be negative";
            }
            else if (time < 3600)
            {
                textBox2.Text = (Math.Round((time/60),2)) + " minutes";
            }
            else if (time < 86400)
            {
                textBox2.Text = Math.Round((time / 3600),2) + " hours";
            }
            else if (time >= 86400)
            {
                textBox2.Text = Math.Round((time/86400),2) + "days";
            }
            else
            {
                textBox2.Text = "check your input";
            }
        }
    }
}