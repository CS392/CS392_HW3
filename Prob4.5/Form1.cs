using System.CodeDom;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBox3.SelectedIndex == this.listBox2.SelectedIndex)
            {
                textBox2.Text=(this.textBox1.Text);
            } else if (this.listBox3.SelectedIndex == 0 
                && this.listBox2.SelectedIndex == 1)

            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = (""+convert *12 );
            } else if (this.listBox3.SelectedIndex == 0
                && this.listBox2.SelectedIndex == 2)
            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = ("" + convert * 36);
            }

            else if (this.listBox3.SelectedIndex == 1
                && this.listBox2.SelectedIndex == 0)
            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = ("" + convert *12);
            }

            else if (this.listBox3.SelectedIndex == 1
                && this.listBox2.SelectedIndex == 2)
            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = ("" + convert / 3);
            }
            else if (this.listBox3.SelectedIndex == 2
                && this.listBox2.SelectedIndex == 0)
            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = ("" + convert / 36);
            }

            else if (this.listBox3.SelectedIndex == 0
                && this.listBox2.SelectedIndex == 2)
            {
                double convert = double.Parse(this.textBox1.Text);
                this.textBox2.Text = ("" + convert / 12);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}