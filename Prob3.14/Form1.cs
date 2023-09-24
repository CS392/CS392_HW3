using System.Numerics;
using System.Windows.Forms.VisualStyles;

namespace Prob3._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AInput.Text = "";
            this.BInput.Text = "";
            this.CInput.Text = "";
            this.AOutput.Text = "";
            this.BOutput.Text = "";
            this.COutput.Text = "";
            this.TotalOutput.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AOutput.Text = $"{BigInteger.Parse(this.AInput.Text) * 15}";
            this.BOutput.Text = $"{BigInteger.Parse(this.BInput.Text) * 12}";
            this.COutput.Text = $"{BigInteger.Parse(this.CInput.Text) * 9}";
            this.TotalOutput.Text = $"{BigInteger.Parse(AOutput.Text) + BigInteger.Parse(BOutput.Text) + BigInteger.Parse(COutput.Text)}";
        }

    }
}