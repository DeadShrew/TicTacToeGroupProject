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
        public static int turnCount = 0;
        
        public static void initializeHeader()
        {
            Form1.textBox1.Text = "Tic-Tac-Toe";
        }

        public static void sleep()
        {
            Thread.Sleep(20000);
        }

        public static void firstTurn() 
        {

            
            Random random = new Random(DateTime.Now.Second);
            int randomisedValue = random.Next(2);

            if (randomisedValue==0)
            {
                player1_turn = true;
                string xTurn = "X turn";
                Form1.textBox1.Text = xTurn; 
                Form1.textBox1.Refresh();

            } else
            {
                player1_turn= false;
                string oTurn = "O turn";
                Form1.textBox1.Text = oTurn;
                Form1.textBox1.Refresh();
            }

        }

        public static void checkForWinner() 
        { 
            
        }

        public static void xWins(int a, int b, int c) { }

        public static void oWins(int a, int b, int c) { }

        public static Boolean getPlayer1Turn()
        {
            return player1_turn; 
        }
    }
}
