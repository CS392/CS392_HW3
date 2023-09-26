using System.Windows.Forms;

namespace Distance_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            start_btn = new Label();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listBox3 = new ListBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // start_btn
            // 
            start_btn.AutoSize = true;
            start_btn.Location = new Point(297, 64);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(150, 15);
            start_btn.TabIndex = 0;
            start_btn.Text = "Enter a distance to convert:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(453, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            listBox2.Location = new Point(24, 30);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 64);
            listBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 117);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Location = new Point(453, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "To";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox3);
            groupBox2.Location = new Point(220, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "From";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            listBox3.Location = new Point(27, 22);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 64);
            listBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 257);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 8;
            label1.Text = "Enter a distance to convert:";
            // 
            // button1
            // 
            button1.Location = new Point(313, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(453, 309);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(start_btn);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label start_btn;
        private TextBox textBox1;
        private ListBox listBox2;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox3;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}