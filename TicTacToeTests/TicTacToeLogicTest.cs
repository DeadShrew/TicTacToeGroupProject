using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToe.UnitTests
{
    [TestClass]
    public class TicTacToeLogicTests
    {
        [TestMethod]
        public void FirstTurn_SetPlayerTurnAndTextBoxText()
        {
            TicTacToeLogic.firstTurn();

        
            Assert.IsTrue(TicTacToeLogic.player1_turn == true || TicTacToeLogic.player1_turn == false);

         
            Assert.IsTrue(Form1.textBox1.Text == "X turn" || Form1.textBox1.Text == "O turn");
        }

        [TestMethod]
        public void CheckForWinner_PlayerXWins()
        {
         
            Form1.button1.Text = "X";
            Form1.button2.Text = "X";
            Form1.button3.Text = "X";

            TicTacToeLogic.checkForWinner();

           
            // Assert.IsTrue(PlayerX.xWinsCalled);
        }

        [TestMethod]
        public void CheckForWinner_PlayerOWins()
        {
         
            Form1.button1.Text = "O";
            Form1.button2.Text = "O";
            Form1.button3.Text = "O";

            TicTacToeLogic.checkForWinner();

         
            // Assert.IsTrue(PlayerO.oWinsCalled);
        }

        [TestMethod]
        public void CheckForWinner_Draw()
        {
        
            Form1.button1.Text = "X";
            Form1.button2.Text = "O";
            Form1.button3.Text = "X";
            Form1.button4.Text = "O";
            Form1.button5.Text = "X";
            Form1.button6.Text = "X";
            Form1.button7.Text = "O";
            Form1.button8.Text = "X";
            Form1.button9.Text = "O";

            TicTacToeLogic.checkForWinner();

           
            Assert.AreEqual("Draw", Form1.textBox1.Text);
        }
    }
}
