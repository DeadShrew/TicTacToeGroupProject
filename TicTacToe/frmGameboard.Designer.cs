﻿namespace TicTacToe
{
    partial class frmGameboard
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
            btnCell1 = new Button();
            btnCell2 = new Button();
            btnCell3 = new Button();
            btnCell4 = new Button();
            btnCell5 = new Button();
            btnCell6 = new Button();
            btnCell7 = new Button();
            btnCell8 = new Button();
            btnCell9 = new Button();
            txtHeader = new TextBox();
            SuspendLayout();
            // 
            // btnCell1
            // 
            btnCell1.Font = new Font("Segoe Script", 30F);
            btnCell1.Location = new Point(3, 124);
            btnCell1.Margin = new Padding(3, 4, 3, 4);
            btnCell1.Name = "btnCell1";
            btnCell1.Size = new Size(151, 136);
            btnCell1.TabIndex = 0;
            btnCell1.UseVisualStyleBackColor = true;
            btnCell1.Click += btnCell1_Click;
            // 
            // btnCell2
            // 
            btnCell2.Font = new Font("Segoe Script", 30F);
            btnCell2.Location = new Point(161, 122);
            btnCell2.Margin = new Padding(3, 4, 3, 4);
            btnCell2.Name = "btnCell2";
            btnCell2.Size = new Size(151, 136);
            btnCell2.TabIndex = 1;
            btnCell2.UseVisualStyleBackColor = true;
            btnCell2.Click += btnCell2_Click;
            // 
            // btnCell3
            // 
            btnCell3.Font = new Font("Segoe Script", 30F);
            btnCell3.Location = new Point(319, 124);
            btnCell3.Margin = new Padding(3, 4, 3, 4);
            btnCell3.Name = "btnCell3";
            btnCell3.Size = new Size(151, 136);
            btnCell3.TabIndex = 2;
            btnCell3.UseVisualStyleBackColor = true;
            btnCell3.Click += btnCell3_Click;
            // 
            // btnCell4
            // 
            btnCell4.Font = new Font("Segoe Script", 30F);
            btnCell4.Location = new Point(3, 267);
            btnCell4.Margin = new Padding(3, 4, 3, 4);
            btnCell4.Name = "btnCell4";
            btnCell4.Size = new Size(151, 136);
            btnCell4.TabIndex = 3;
            btnCell4.UseVisualStyleBackColor = true;
            btnCell4.Click += btnCell4_Click;
            // 
            // btnCell5
            // 
            btnCell5.Font = new Font("Segoe Script", 30F);
            btnCell5.Location = new Point(161, 267);
            btnCell5.Margin = new Padding(3, 4, 3, 4);
            btnCell5.Name = "btnCell5";
            btnCell5.Size = new Size(151, 136);
            btnCell5.TabIndex = 4;
            btnCell5.UseVisualStyleBackColor = true;
            btnCell5.Click += btnCell5_Click;
            // 
            // btnCell6
            // 
            btnCell6.Font = new Font("Segoe Script", 30F);
            btnCell6.Location = new Point(319, 267);
            btnCell6.Margin = new Padding(3, 4, 3, 4);
            btnCell6.Name = "btnCell6";
            btnCell6.Size = new Size(151, 136);
            btnCell6.TabIndex = 5;
            btnCell6.UseVisualStyleBackColor = true;
            btnCell6.Click += btnCell6_Click;
            // 
            // btnCell7
            // 
            btnCell7.Font = new Font("Segoe Script", 30F);
            btnCell7.Location = new Point(3, 410);
            btnCell7.Margin = new Padding(3, 4, 3, 4);
            btnCell7.Name = "btnCell7";
            btnCell7.Size = new Size(151, 136);
            btnCell7.TabIndex = 6;
            btnCell7.UseVisualStyleBackColor = true;
            btnCell7.Click += btnCell7_Click;
            // 
            // btnCell8
            // 
            btnCell8.Font = new Font("Segoe Script", 30F);
            btnCell8.Location = new Point(161, 410);
            btnCell8.Margin = new Padding(3, 4, 3, 4);
            btnCell8.Name = "btnCell8";
            btnCell8.Size = new Size(151, 136);
            btnCell8.TabIndex = 7;
            btnCell8.UseVisualStyleBackColor = true;
            btnCell8.Click += btnCell8_Click;
            // 
            // btnCell9
            // 
            btnCell9.Font = new Font("Segoe Script", 30F);
            btnCell9.Location = new Point(319, 410);
            btnCell9.Margin = new Padding(3, 4, 3, 4);
            btnCell9.Name = "btnCell9";
            btnCell9.Size = new Size(151, 136);
            btnCell9.TabIndex = 8;
            btnCell9.UseVisualStyleBackColor = true;
            btnCell9.Click += btnCell9_Click;
            // 
            // txtHeader
            // 
            txtHeader.BackColor = SystemColors.Info;
            txtHeader.Font = new Font("Segoe Script", 40F);
            txtHeader.Location = new Point(3, 15);
            txtHeader.Margin = new Padding(3, 4, 3, 4);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(466, 92);
            txtHeader.TabIndex = 9;
            txtHeader.Text = "Tic Tac Toe";
            txtHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // frmGameboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(472, 548);
            Controls.Add(txtHeader);
            Controls.Add(btnCell9);
            Controls.Add(btnCell8);
            Controls.Add(btnCell7);
            Controls.Add(btnCell6);
            Controls.Add(btnCell5);
            Controls.Add(btnCell4);
            Controls.Add(btnCell3);
            Controls.Add(btnCell2);
            Controls.Add(btnCell1);
            Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGameboard";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        // public Button[] buttons = new Button[][btnCell1, btnCell2, btnCell3, btnCell4, btnCell5, btnCell6, btnCell7, btnCell8, btnCell9];
        public Button btnCell1;
        public Button btnCell2;
        public Button btnCell3;
        public Button btnCell4;
        public Button btnCell5;
        public Button btnCell6;
        public Button btnCell7;
        public  Button btnCell8;
        public  Button btnCell9;
        public TextBox txtHeader;
    }
}