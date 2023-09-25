namespace Prob5._10
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
            GuessLabel = new Label();
            button1 = new Button();
            Input = new TextBox();
            Hint = new Label();
            randomNum = new Label();
            SuspendLayout();
            // 
            // GuessLabel
            // 
            GuessLabel.AutoSize = true;
            GuessLabel.Location = new Point(248, 141);
            GuessLabel.Name = "GuessLabel";
            GuessLabel.Size = new Size(267, 20);
            GuessLabel.TabIndex = 0;
            GuessLabel.Text = "Enter a number from 1 to 100 to guess!";
            // 
            // button1
            // 
            button1.Location = new Point(303, 236);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Guess";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Input
            // 
            Input.Location = new Point(288, 203);
            Input.Name = "Input";
            Input.Size = new Size(125, 27);
            Input.TabIndex = 2;
            Input.TextChanged += Input_TextChanged;
            // 
            // Hint
            // 
            Hint.AutoSize = true;
            Hint.Location = new Point(328, 170);
            Hint.Name = "Hint";
            Hint.Size = new Size(0, 20);
            Hint.TabIndex = 3;
            // 
            // randomNum
            // 
            randomNum.AutoSize = true;
            randomNum.Location = new Point(461, 205);
            randomNum.Name = "randomNum";
            randomNum.Size = new Size(0, 20);
            randomNum.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(randomNum);
            Controls.Add(Hint);
            Controls.Add(Input);
            Controls.Add(button1);
            Controls.Add(GuessLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GuessLabel;
        private Button button1;
        private TextBox Input;
        private Label Hint;
        private Label randomNum;
    }
}