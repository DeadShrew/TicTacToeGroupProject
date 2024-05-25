using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerO
    {
        public static void oWins()
        {
            Form1.textBox1.Text = "0 wins!";
            TicTacToeLogic.hasWon = true;

            if (
                (Form1.button1.Text == "O") &&
                (Form1.button2.Text == "O") &&
                (Form1.button3.Text == "O"))
            {

                Form1.button1.ForeColor = Color.Red;
                Form1.button2.ForeColor = Color.Red;
                Form1.button3.ForeColor = Color.Red;
            }
            if (
                (Form1.button4.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button6.Text == "O"))
            {

                Form1.button4.ForeColor = Color.Red;
                Form1.button5.ForeColor = Color.Red;
                Form1.button6.ForeColor = Color.Red;
            }
            if (
                (Form1.button7.Text == "O") &&
                (Form1.button8.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                Form1.button7.ForeColor = Color.Red;
                Form1.button8.ForeColor = Color.Red;
                Form1.button9.ForeColor = Color.Red;
            }
            if (
                (Form1.button1.Text == "O") &&
                (Form1.button4.Text == "O") &&
                (Form1.button7.Text == "O"))
            {

                Form1.button1.ForeColor = Color.Red;
                Form1.button4.ForeColor = Color.Red;
                Form1.button7.ForeColor = Color.Red;
            }
            if (
                (Form1.button2.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button8.Text == "O"))
            {

                Form1.button2.ForeColor = Color.Red;
                Form1.button5.ForeColor = Color.Red;
                Form1.button8.ForeColor = Color.Red;
            }
            if (
                (Form1.button3.Text == "O") &&
                (Form1.button6.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                Form1.button3.ForeColor = Color.Red;
                Form1.button6.ForeColor = Color.Red;
                Form1.button9.ForeColor = Color.Red;
            }
            if (
                (Form1.button1.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                Form1.button1.ForeColor = Color.Red;
                Form1.button5.ForeColor = Color.Red;
                Form1.button9.ForeColor = Color.Red;
            }
            if (
                (Form1.button3.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button7.Text == "O"))
            {

                Form1.button3.ForeColor = Color.Red;
                Form1.button5.ForeColor = Color.Red;
                Form1.button7.ForeColor = Color.Red;
            }

        }
    }
}
