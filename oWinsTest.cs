using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using TicTacToe;

namespace TicTacToe.UnitTests
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void TestFirstTurn()
        {
            TicTacToeLogic.firstTurn();


            Assert.IsNotNull(TicTacToeLogic.getPlayer1Turn());
        }

        [TestMethod]
        public void TestCheckForWinner()
        {
             TicTacToeLogic.checkForWinner();

         }

        [TestMethod]
        public void TestPlayerOWins()
        {
  
            Form1.textBox1 = new System.Windows.Forms.TextBox();
            Form1.button1 = new System.Windows.Forms.Button();
            Form1.button2 = new System.Windows.Forms.Button();
            Form1.button3 = new System.Windows.Forms.Button();

            PlayerO.oWins();
            Assert.IsTrue(TicTacToeLogic.hasWon);
        }

        [TestMethod]
        public void TestPlayerXWins()
        {
   
            Form1.textBox1 = new System.Windows.Forms.TextBox();
            Form1.button1 = new System.Windows.Forms.Button();
            Form1.button2 = new System.Windows.Forms.Button();
            Form1.button3 = new System.Windows.Forms.Button();
  
            PlayerX.xWins();

  
            Assert.IsTrue(TicTacToeLogic.hasWon);
        }

        [TestMethod]
        public void TestButtonClickEvents()
        {

        }
    }
}
