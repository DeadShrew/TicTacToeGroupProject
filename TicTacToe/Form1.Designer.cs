namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Script", 30F);
            button1.Location = new Point(3, 124);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(151, 136);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Script", 30F);
            button2.Location = new Point(161, 122);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(151, 136);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Script", 30F);
            button3.Location = new Point(319, 124);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(151, 136);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Script", 30F);
            button4.Location = new Point(3, 267);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(151, 136);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Script", 30F);
            button5.Location = new Point(161, 267);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(151, 136);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Script", 30F);
            button6.Location = new Point(319, 267);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(151, 136);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Script", 30F);
            button7.Location = new Point(3, 410);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(151, 136);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe Script", 30F);
            button8.Location = new Point(161, 410);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(151, 136);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Script", 30F);
            button9.Location = new Point(319, 410);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(151, 136);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe Script", 40F);
            textBox1.Location = new Point(3, 15);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 92);
            textBox1.TabIndex = 9;
            textBox1.Text = "Tic Tac Toe";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(472, 548);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

             

        public static Button button1;
        public static Button button2;
        public static Button button3;
        public static Button button4;
        public static Button button5;
        public static Button button6;
        public static Button button7;
        public static Button button8;
        public static Button button9;
        public static TextBox textBox1;

        public static Button[] buttons = [button1, button2, button3, button4, button5, button6, button7, button8, button9];
    }
}
