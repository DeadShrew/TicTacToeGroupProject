using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class TicTacToeLogic
    {
        
        public static Boolean player1_turn;
        public static Boolean hasWon = false;
        public static int turnCount = 0;

        public static void firstTurn() 
        {

            
            Random random = new Random(DateTime.Now.Second);
            int randomisedValue = random.Next(2);

            if (randomisedValue==0)
            {
                player1_turn = true;
                string xTurn = "X turn";
                Form1.textBox1.Text = xTurn; 

            } else
            {
                player1_turn= false;
                string oTurn = "O turn";
                Form1.textBox1.Text = oTurn;
 
            }

        }

        public static void checkForWinner() 
        {
            

            if(
                (Form1.button1.Text == "X") &&
                (Form1.button2.Text == "X") &&
                (Form1.button3.Text == "X"))  {

                PlayerX.xWins();
            }
            if (
                (Form1.button4.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button6.Text == "X"))
            {

                PlayerX.xWins();
            }
            if (
                (Form1.button7.Text == "X") &&
                (Form1.button8.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                PlayerX.xWins();
            }
            if (
                (Form1.button1.Text == "X") &&
                (Form1.button4.Text == "X") &&
                (Form1.button7.Text == "X"))
            {

                PlayerX.xWins();
            }
            if (
                (Form1.button2.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button8.Text == "X"))
            {

                PlayerX.xWins();
            }
            if (
                (Form1.button3.Text == "X") &&
                (Form1.button6.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                PlayerX.xWins();
            }
            if (
                (Form1.button1.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button9.Text == "X"))
            {

                PlayerX.xWins(); ;
            }
            if (
                (Form1.button3.Text == "X") &&
                (Form1.button5.Text == "X") &&
                (Form1.button7.Text == "X"))
            {

                PlayerX.xWins();
            }
            ///////////////////////////////////////////////////////
            if (
                (Form1.button1.Text == "O") &&
                (Form1.button2.Text == "O") &&
                (Form1.button3.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button4.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button6.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button7.Text == "O") &&
                (Form1.button8.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button1.Text == "O") &&
                (Form1.button4.Text == "O") &&
                (Form1.button7.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button2.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button8.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button3.Text == "O") &&
                (Form1.button6.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button1.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button9.Text == "O"))
            {

                PlayerO.oWins();
            }
            if (
                (Form1.button3.Text == "O") &&
                (Form1.button5.Text == "O") &&
                (Form1.button7.Text == "O"))
            {

                PlayerO.oWins();
            }

            if (turnCount == 9 && hasWon == false) { Form1.textBox1.Text = "Draw"; }
        }

        public static Boolean getPlayer1Turn()
        {
            return player1_turn; 
        }
    }
}
