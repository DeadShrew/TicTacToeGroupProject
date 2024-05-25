using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerX
    {
        public static void xWins()
        {
            Form1.textBox1.Text = "X wins!";
            TicTacToeLogic.hasWon = true;

            if (
                (Form1.button1.Text == "X") &&
                (Form1.button2.Text == "X") &&
                (Form1.button3.Text == "X"))
            {

                Form1.button1.ForeColor = Color.Green;
                Form1.button2.ForeColor = Color.Green;
                Form1.button3.ForeColor = Color.Green;
            }
            if (
                (Form1.button4.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button6.Text == "X"))
            {

                Form1.button4.ForeColor = Color.Green;
                Form1.button5.ForeColor = Color.Green;
                Form1.button6.ForeColor = Color.Green;
            }
            if (
                (Form1.button7.Text == "X") &&
                (Form1.button8.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                Form1.button7.ForeColor = Color.Green;
                Form1.button8.ForeColor = Color.Green;
                Form1.button9.ForeColor = Color.Green;
            }
            if (
                (Form1.button1.Text == "X") &&
                (Form1.button4.Text == "X") &&
                (Form1.button7.Text == "X"))
            {

                Form1.button1.ForeColor = Color.Green;
                Form1.button4.ForeColor = Color.Green;
                Form1.button7.ForeColor = Color.Green;
            }
            if (
                (Form1.button2.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button8.Text == "X"))
            {

                Form1.button2.ForeColor = Color.Green;
                Form1.button5.ForeColor = Color.Green;
                Form1.button8.ForeColor = Color.Green;
            }
            if (
                (Form1.button3.Text == "X") &&
                (Form1.button6.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                Form1.button3.ForeColor = Color.Green;
                Form1.button6.ForeColor = Color.Green;
                Form1.button9.ForeColor = Color.Green;
            }
            if (
                (Form1.button1.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                Form1.button1.ForeColor = Color.Green;
                Form1.button5.ForeColor = Color.Green;
                Form1.button9.ForeColor = Color.Green;
            }
            if (
                (Form1.button3.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button7.Text == "X"))
            {

                Form1.button3.ForeColor = Color.Green;
                Form1.button5.ForeColor = Color.Green;
                Form1.button7.ForeColor = Color.Green;
            }
        }
    }
}
